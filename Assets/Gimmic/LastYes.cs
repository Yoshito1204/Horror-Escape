using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LastYes : MonoBehaviour
{
    float r,g,b;
    float fadespeed = 0.03f;
    // Start is called before the first frame update
    void Start()
    {
        r = gameObject.GetComponent<Image>().color.r;
        g = gameObject.GetComponent<Image>().color.g;
        b = gameObject.GetComponent<Image>().color.b;
    }

    // Update is called once per frame
    void Update()
    {
        if(Gimmic7.IsYes == true){
           gameObject.GetComponent<Image>().color = new Color(r,g,b,255);
           r -= fadespeed;
           g -= fadespeed;
           b -= fadespeed;
        }
    }
}
