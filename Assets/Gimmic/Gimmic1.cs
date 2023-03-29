using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gimmic1 : MonoBehaviour
{
    
    public GameObject Stage1_fence;
    public Sprite Stage1_nofence;
    public static bool hasHummer = false;
    private SearchButton SearchB;
    public Sprite Hummer;
    public GameObject nowItem;
    private Image nowitem;
    private AudioSource audioSource;
    private void Start() {
      SearchB = GetComponent<SearchButton>();
      audioSource = GetComponent<AudioSource>();
    }

    void Update(){
      nowitem = nowItem.GetComponent<Image>();
      if(nowitem.sprite == Hummer){
          hasHummer = true;
           SearchB.outcome = "フェンスを破壊した。";    
        }else{
          hasHummer = false;
        }

    }

//ハンマーを持っていたらフェンスを破壊
    public void OnClickGimmic1(){
        
        bool hasItem = ItemBox.instance.CanUseItem(Item.ItemType.Hummer);
        
        if(hasItem == true && hasHummer == true){
          Stage1_fence.GetComponent<Image>().sprite = Stage1_nofence;
          ItemBox.instance.UseItem(Item.ItemType.Hummer);
          nowitem.color = new Color(255,255,255,0f);
          audioSource.PlayOneShot(audioSource.clip);
        }
    }

    
}
