using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropHead : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Translate(0,0.5f,0);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Stop"){
            this.gameObject.SetActive(false);
        }
    }
}
