using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gimmic5 : MonoBehaviour
{
    public GameObject Stage5_locked;
    public Sprite Stage5_nolocked;
    public static bool hasKey = false;
    private SearchButton SearchB;
    public Sprite Key;
    public GameObject Injector;
    public GameObject nowItem;
    private Image nowitem;
    private AudioSource audioSource;
    public AudioClip unlock;
    // Start is called before the first frame update
    void Start()
    {
        SearchB = GetComponent<SearchButton>();
        Injector.SetActive(false);
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        nowitem = nowItem.GetComponent<Image>();
      if(nowitem.sprite == Key){
          hasKey = true;
           SearchB.outcome = "開いた";    
        }else if(ItemBox.instance.usedkey == false){
          hasKey = false;
          SearchB.outcome = "鍵がかかっている"; 
        }
    }

//鍵を持っていたら南京錠を開ける
    public void OnClickGimmic5(){
         bool hasItem = ItemBox.instance.CanUseItem(Item.ItemType.Key);

         if(hasItem == true && hasKey == true){
          audioSource.PlayOneShot(unlock);
          Stage5_locked.GetComponent<Image>().sprite = Stage5_nolocked;
          ItemBox.instance.UseItem(Item.ItemType.Key);
          nowitem.color = new Color(255,255,255,0f);
          Injector.SetActive(true);
        }
    }
}
