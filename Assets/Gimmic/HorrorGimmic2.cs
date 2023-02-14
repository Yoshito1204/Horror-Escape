using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HorrorGimmic2 : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip se;
    public AudioClip se2;
    public GameObject dollface;
    int rnd;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        dollface.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickDoll(){
        
        StartCoroutine("Doll");
    }

    IEnumerator Doll(){
       rnd = Random.Range(0,5);
        
        if(rnd == 3 || rnd == 4){
            audioSource.Stop();
            audioSource.PlayOneShot(se2,1.0f);
            SearchButton.instance.ImageText.SetActive(false);
            dollface.SetActive(true);
            if (SystemInfo.supportsVibration)
        {
           Handheld.Vibrate();
        }
            
        }else {
            audioSource.Stop();
            audioSource.PlayOneShot(se,0.7f);
            dollface.SetActive(false);
        }

        yield return new WaitForSeconds(2);

        if(dollface.activeSelf == true){
            dollface.SetActive(false);
        }
    }
}
