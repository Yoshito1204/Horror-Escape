using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour
{
    public GameObject itembox;
    public GameObject Map;
    public GameObject Hint;
    public GameObject Back;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickBack(){
       itembox.transform.localPosition = new Vector2(0,1500);
           }
    
    public void MapBack(){
      Map.transform.localPosition = new Vector2(2000,1500);
    }

    public void HintBack(){
      Hint.transform.localPosition = new Vector2(3000,1500);
      Hint.transform.GetChild(9).transform.localPosition = new Vector2(4000,1500);
    }

    public void BackBack(){
      if(Back != null){
        Back.SetActive(false);
        //this.gameObject.SetActive(false);
      }
    }
}
