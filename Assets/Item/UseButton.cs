using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UseButton : MonoBehaviour
{
    private GameObject use;
    public GameObject nowItem;
    private Sprite nowuse;
    private Image nowitem;
    // Start is called before the first frame update
    void Start()
    {
        nowitem = nowItem.GetComponent<Image>();
        nowitem.color = new Color(255,255,255,0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickUse(){
        if(ItemBox.instance.ItemList.Count == 1){
          use = GameObject.Find(ItemBox.instance.ItemList[0]);
          nowuse = use.transform.GetChild(0).GetComponent<Image>().sprite;
          nowitem.color = new Color(255,255,255,1.0f);
          nowitem.sprite = nowuse;
          nowitem.SetNativeSize();
        }else {
            return;
        }
    }
}
