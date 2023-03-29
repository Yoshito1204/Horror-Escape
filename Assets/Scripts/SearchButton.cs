using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchButton : MonoBehaviour
{
    public static SearchButton instance;
    public GameObject ImageText;
    private Image image;
    public string outcome;
    public GameObject MapButton;
    private Text ImageTextChild;
    float alpha,alpha2;
     private AudioSource audioSource;
     

    private void Awake() {
        if(instance == null){
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        if(MapButton != null){
          MapButton.SetActive(false);
        }else{
            return;
        }
        
        ImageText.SetActive(false);
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
         
    }

//調べる
    public void SearchArea(){
        if(ImageText.activeSelf == false){
            ImageText.SetActive(true);
        image = ImageText.GetComponent<Image>();
        image.color = new Color(255,255,255,0.6f);
        ImageTextChild = ImageText.transform.GetChild(0).GetComponent<Text>();
        ImageTextChild.color = new Color(255,255,255,1.0f);
        ImageTextChild.text = outcome;
       
        }else if(ImageText.activeSelf == false){
            ImageText.SetActive(false);
            ImageText.SetActive(true);
        }
        
    }

     public void OnDoorOpen(){
      
        if(ItemBox.instance.usedhummer == true){
            outcome = "";
            ImageText.SetActive(false);
            PanelChanger.instance.ShowPanel(PanelChanger.Panel.Panel3);
            if(MapButton != null){
               MapButton.SetActive(true);
            }else{
                return;
            }
            
           audioSource.PlayOneShot(audioSource.clip);
        }
          
    }
}
