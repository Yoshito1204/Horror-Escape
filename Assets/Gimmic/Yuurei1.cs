using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Yuurei1 : MonoBehaviour
{
    float alpha;
   public float fadespeed;
    // Start is called before the first frame update
    void Start()
    {
        alpha = gameObject.GetComponent<Image>().color.a;
    }

    // Update is called once per frame
    void Update()
    {
        if(alpha >= 0){
           gameObject.GetComponent<Image>().color = new Color(255,255,255,alpha);
           alpha -= fadespeed;
        }
        
    }
}
