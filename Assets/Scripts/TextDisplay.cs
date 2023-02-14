using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDisplay : MonoBehaviour
{
    public Text text;
    private bool IsFadeout = false;
    float fadespeed = 0.03f;
    float alpha,alpha2;
    Image textback;
    public static TextDisplay instance;

    private void Awake() {
       if(instance == null){
        instance = this;
       }  
    }
    // Start is called before the first frame update
    void Start()
    {
        alpha = text.color.a;
        textback = GetComponent<Image>();
        alpha2 = textback.color.a;
    }

    // Update is called once per frame
    void Update()
    {
        if(IsFadeout == true){
            text.color = new Color(255,255,255,alpha);
            textback.color = new Color(255,255,255,alpha2);
            alpha -= fadespeed;
           alpha2 -= fadespeed;
        if(alpha <= 0){
            this.gameObject.SetActive(false);
            IsFadeout = false;
        }
        }else{
            return;
        }
    }

    public void Fade(){
        IsFadeout = true;
        
        
    }
}
