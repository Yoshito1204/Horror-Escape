using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HorrorGimmic4 : MonoBehaviour
{
    private int knock;
    public GameObject face;
    public GameObject DropFace;
    private AudioSource audioSource;
    public AudioClip windowknock;
    public AudioClip lowpiano;

    // Start is called before the first frame update
    void Start()
    {
        knock = 0;
        face.SetActive(false);
        DropFace.SetActive(false);
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void KnockWindow(){
       knock++;
       StartCoroutine("Window");
    }

    IEnumerator Window(){

        if(knock % 3 == 0){
        DropFace.SetActive(true);
        face.SetActive(false);
        audioSource.PlayOneShot(lowpiano);
       }else{
        DropFace.SetActive(false);
        face.SetActive(true);
        audioSource.PlayOneShot(windowknock);
       }

        yield return new WaitForSeconds(2);

        if(DropFace.activeSelf == true){
            DropFace.transform.localPosition = new Vector3(0,950,0);
            DropFace.SetActive(false);
        }else{
            face.SetActive(false);
        }
    }
}
