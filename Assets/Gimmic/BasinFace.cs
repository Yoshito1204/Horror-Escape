using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasinFace : MonoBehaviour
{
    float fadespeed = 0.01f;
    float alpha;
    
    // Start is called before the first frame update
    void Start()
    {
        alpha = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if(alpha >= 0){
           gameObject.GetComponent<Image>().color = new Color(255,255,255,alpha);
           alpha -= fadespeed;
           Destroy(gameObject,1.5f);
        }else if(alpha == 0){
            //gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
}
