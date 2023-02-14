using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextScroll : MonoBehaviour
{
    private bool IsStop;
    // Start is called before the first frame update
    void Start()
    {
        IsStop = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(IsStop == false){
           this.gameObject.transform.Translate(0,0.02f,0);
        }else{
            return;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Stop"){
            IsStop = true;
        }
    }
}
