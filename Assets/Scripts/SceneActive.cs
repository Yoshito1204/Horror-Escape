using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Google.Play.Review;

public class SceneActive : MonoBehaviour
{
    public static SceneActive instance;
    private int titlenum;
    private void Awake()
  {
    if( instance == null)
    {
      instance = this;
      DontDestroyOnLoad(gameObject);
    }
    else
    {
      Destroy(gameObject);
    }
  }
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.activeSceneChanged += OnActiveSceneChanged;
        SceneManager.sceneLoaded              += OnSceneLoaded;
        SceneManager.sceneUnloaded          += OnSceneUnloaded; 
        titlenum = 0;
    }

    void OnActiveSceneChanged( Scene prevScene, Scene nextScene )
    {
        Debug.Log ( prevScene.name + "->"  + nextScene.name );
    }

//Titleシーンを訪れた数
    void OnSceneLoaded( Scene scene, LoadSceneMode mode )
    {
        if(scene.name == "Title"){
            titlenum++;
        }
        if(titlenum == 1){
            StartCoroutine(ShowReviewCoroutine());
        }
        Debug.Log ( scene.name + " scene loaded");
        Debug.Log ( titlenum);
    }

    void OnSceneUnloaded( Scene scene )
    {
        Debug.Log ( scene.name + " scene unloaded");
    }
    // Update is called once per frame
    //レビュー依頼を表示
private IEnumerator ShowReviewCoroutine(){
  var reviewManager = new ReviewManager();
  var requestFlowOperation = reviewManager.RequestReviewFlow();
  yield return requestFlowOperation;

  if (requestFlowOperation.Error != ReviewErrorCode.NoError){// エラーの場合はここで止まる
    Debug.LogError($"レビュー依頼エラー {requestFlowOperation.Error}");
    yield break;
  }
  var playReviewInfo = requestFlowOperation.GetResult(); 
  var launchFlowOperation = reviewManager.LaunchReviewFlow(playReviewInfo);
  yield return launchFlowOperation;

  if (launchFlowOperation.Error != ReviewErrorCode.NoError){// エラーの場合はここで止まる
    Debug.LogError($"レビュー依頼エラー {requestFlowOperation.Error}");
    yield break;
  }
}
}
