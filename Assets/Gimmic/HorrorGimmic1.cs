using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HorrorGimmic1 : MonoBehaviour
{
    public GameObject Window;
    public Sprite WindowCrack;
    public GameObject yuurei1;
    public GameObject drophead;
    private SearchButton SearchB;
    private bool IsCrack;
    private int tapnum;
    private AudioSource audioSource1;
    private AudioSource audioSource2;

    // Start is called before the first frame update
    void Start()
    {
        SearchB = GetComponent<SearchButton>();
        IsCrack = false;
        tapnum = 0;
        yuurei1.SetActive(false);
        drophead.SetActive(false);
        AudioSource[] audioSources = GetComponents<AudioSource>();
        audioSource1 = audioSources[0];
        audioSource2 = audioSources[1];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickHorror1(){
        tapnum++;
 
        if(tapnum == 2){
           StartCoroutine("ChangeWindow");
        }
         
    }

//幽霊が出た後、窓ガラスが割れて、大きな顔が落ちてくる
    IEnumerator ChangeWindow()
    {
        yuurei1.SetActive(true);
        PanelChanger.instance.rightArrow.SetActive(false);
 
        yield return new WaitForSeconds(2);
 
        audioSource1.PlayOneShot(audioSource1.clip);
        Window.GetComponent<Image>().sprite = WindowCrack;
        SearchB.outcome = "窓にヒビがはいっている。";
        IsCrack = true;

        yield return new WaitForSeconds(1);

        drophead.SetActive(true);
        audioSource2.PlayOneShot(audioSource2.clip);
        PanelChanger.instance.rightArrow.SetActive(true);
    }
}
