using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HorrorGimmic3 : MonoBehaviour
{
    private int mojinum;
    public GameObject hands;
    private AudioSource audioSource;
    private SearchButton SearchB;
    // Start is called before the first frame update
    void Start()
    {
        mojinum = 0;
        hands.SetActive(false);
        audioSource = GetComponent<AudioSource>();
        SearchB = GetComponent<SearchButton>();
    }

    // Update is called once per frame
    void Update()
    {
        if(hands.activeSelf == true){
            SearchB.outcome = "びっくりした...";
        }
    }

//スマホをバイブレーションさせながらたくさんの手を出現させる
    public void OnClickHorror3(){
        mojinum++;

        if(mojinum == 3){
           hands.SetActive(true);
        audioSource.PlayOneShot(audioSource.clip);

        if (SystemInfo.supportsVibration)
          {
           Handheld.Vibrate();
          }
        }
        
    }
}
