using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Phone : MonoBehaviour
{
    private AudioSource audioSource;
    public GameObject CallPhone;
    public AudioClip call;
    public AudioClip umeki;

    private void Awake() {
        audioSource = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnEnable() {
        audioSource.PlayOneShot(call);
        audioSource.loop = true;
        CallPhone.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCall(){
       PanelChanger.instance.CallPhone.SetActive(true);
       audioSource.loop = false;
       audioSource.PlayOneShot(umeki);
       
    }

    public void NoCall(){
        PanelChanger.instance.CallPhone.SetActive(false);
        PanelChanger.instance.Phone.SetActive(false);
    }


}
