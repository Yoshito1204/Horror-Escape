using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gimmic4 : MonoBehaviour
{
    public GameObject Stage4_zaru;
    public Sprite Stage4_bloodzaru;
    public static bool hasBlood = false;
    private SearchButton SearchB;
    public Sprite Blood;
    public GameObject Key;
    public GameObject nowItem;
    private Image nowitem;
    private AudioSource audioSource;
    public AudioClip blood;
    // Start is called before the first frame update
    void Start()
    {
        SearchB = GetComponent<SearchButton>();
        Key.SetActive(false);
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        nowitem = nowItem.GetComponent<Image>();
      if(nowitem.sprite == Blood){
          hasBlood = true;
           SearchB.outcome = "血液パックを破いた";    
        }else if(ItemBox.instance.usedblood == false){
          hasBlood = false;
          SearchB.outcome = "水切ができる..."; 
        }
    }

//血液パックを持っていたらざるの中に破く
    public void OnClickGimmic4(){
         bool hasItem = ItemBox.instance.CanUseItem(Item.ItemType.Blood);

         if(hasItem == true && hasBlood == true){
          audioSource.PlayOneShot(blood);
          Stage4_zaru.GetComponent<Image>().sprite = Stage4_bloodzaru;
          
          ItemBox.instance.UseItem(Item.ItemType.Blood);
          nowitem.color = new Color(255,255,255,0f);
          Key.SetActive(true);
        }
    }
}
