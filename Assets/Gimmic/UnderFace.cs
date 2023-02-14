using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnderFace : MonoBehaviour
{
    public GameObject start;
    public GameObject end;
    private float speed = 5f;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnEnable() {
       // StartCoroutine()
    }

    // Update is called once per frame
    void Update()
    {
        if(HorrorGimmic6.instance.IsMove == true){
            //transform.Translate(-speed,0,0);
            rb.velocity = new Vector2(0,speed);
        }else if(HorrorGimmic6.instance.IsMove == false){
            //transform.Translate(speed,0,0);
             rb.velocity = new Vector2(0,-speed);
        }
        Debug.Log(HorrorGimmic5.instance.IsMove);
    }

    public void Onclick(){
        HorrorGimmic6.instance.IsMove = false;
    }

  

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "end"){
           // this.gameObject.transform.position = new Vector3(end.transform.position.x,end.transform.position.y,end.transform.position.z);
           //transform.Translate(0,0,0);
           rb.velocity = new Vector2(0,0);
        }else if(other.gameObject.tag == "start"){
            this.gameObject.SetActive(false);
        }
    }
    
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "end"){
           // this.gameObject.transform.position = new Vector3(end.transform.position.x,end.transform.position.y,end.transform.position.z);
           //transform.Translate(0,0,0);
           rb.velocity = new Vector2(0,0);
        }else if(other.gameObject.tag == "start"){
            this.gameObject.SetActive(false);
        }
    }
}
