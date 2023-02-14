using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorGimmic : MonoBehaviour
{
    public GameObject Stage1_now;
    public Sprite no_fence;
    
    // Start is called before the first frame update
    void Start()
    {
        //dooropen = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDoorOpen(){
       // Stage1_now.GetComponent<Image>().sprite = no_fence;
        if(ItemBox.instance.usedhummer == true){
           PanelChanger.instance.dooropen = true;
        }
          
    }
}
