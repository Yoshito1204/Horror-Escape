using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public GameObject LastFace;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        if(LastFace != null){
           LastFace.SetActive(false);
        }else{
            return;
        }
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToMain(){
        SceneManager.LoadScene("SampleScene");
    }

    public void ToOpening(){
        SceneManager.LoadScene("Opening");
    }

    public void End(){
        
       StartCoroutine("BackToTitle");
    }

    IEnumerator BackToTitle(){
        LastFace.SetActive(true);
        audioSource.PlayOneShot(audioSource.clip);
       if (SystemInfo.supportsVibration)
       {
           Handheld.Vibrate();
       }

       yield return new WaitForSeconds(3);

       SceneManager.LoadScene("Title");

    }
}
