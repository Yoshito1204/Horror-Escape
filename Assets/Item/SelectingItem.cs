using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectingItem : MonoBehaviour
{
    public GameObject frame;
    public GameObject ItemDetail;
    public string ItemDetailText;
    public string ItemDetailText2;
    private int clicknum;
     private bool IsSelected;
     private Sprite ThisItem;
     private Image itemdetail;
     private Text itemdetailtext;
     private Text itemdetailtext2;
   
    // Start is called before the first frame update
    void Start()
    {
       clicknum = 1;
       itemdetail = ItemDetail.transform.GetChild(0).GetComponent<Image>();
       itemdetailtext = ItemDetail.transform.GetChild(1).GetComponent<Text>();
       itemdetailtext2 = ItemDetail.transform.GetChild(2).GetComponent<Text>();
       ThisItem = this.gameObject.transform.GetChild(0).GetComponent<Image>().sprite;
       ItemDetail.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickSelect(){
      //clicknum++;
      
      if(ItemBox.instance.ItemList.Count < 1 && IsSelected == false){
         frame.GetComponent<Image>().color = Color.red;
         IsSelected = true;
         ItemBox.instance.ItemList.Add(gameObject.name);
         ItemDetail.SetActive(true);
         itemdetail.sprite = ThisItem;
         itemdetailtext.text = ItemDetailText;
         itemdetailtext2.text = ItemDetailText2;
         itemdetail.SetNativeSize();
      }else if(ItemBox.instance.ItemList.Count <= 1 && IsSelected == true){
         frame.GetComponent<Image>().color = Color.white;
         IsSelected = false;
         ItemBox.instance.ItemList.Remove(gameObject.name);
         ItemDetail.SetActive(false);
      }  
      Debug.Log(this.gameObject.name);
      Debug.Log(IsSelected);
      Debug.Log(ItemBox.instance.ItemList.Count);
    }

    

}
