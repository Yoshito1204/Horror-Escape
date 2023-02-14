using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gimmic3 : MonoBehaviour
{
    public GameObject Stage3_door;
    public Sprite Stage3_operation;
    public static bool hasBar = false;
    private SearchButton SearchB;
    public GameObject BedB;
    public Sprite Bar;
    public GameObject nowItem;
    private Image nowitem;
    private AudioSource audioSource;
    public AudioClip dooropen;

    // Start is called before the first frame update
    void Start()
    {
        SearchB = GetComponent<SearchButton>();
        BedB.SetActive(false);
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        nowitem = nowItem.GetComponent<Image>();
      if(nowitem.sprite == Bar){
          hasBar = true;
           SearchB.outcome = "なぜ手術室が？";    
        }else if(ItemBox.instance.usedbar == false){
          hasBar = false;
          SearchB.outcome = "木の板が打ち付けられている"; 
        }
    }

    public void OnClickGimmic3(){
         bool hasItem = ItemBox.instance.CanUseItem(Item.ItemType.Bar);
        
        if(hasItem == true && hasBar == true){
          audioSource.PlayOneShot(dooropen);
          Stage3_door.GetComponent<Image>().sprite = Stage3_operation;
          ItemBox.instance.UseItem(Item.ItemType.Bar);
          nowitem.color = new Color(255,255,255,0f);
          PanelChanger.instance.rightArrow.SetActive(true);
          PanelChanger.instance.leftArrow.SetActive(true);
          BedB.SetActive(true);
          gameObject.SetActive(false);
        }
    }
}
