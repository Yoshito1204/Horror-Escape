using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yuurei2 : MonoBehaviour
{
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(audioSource.clip);
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Translate(-0.4f,0,0);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Stop"){
            this.gameObject.SetActive(false);
        }
    }
}
