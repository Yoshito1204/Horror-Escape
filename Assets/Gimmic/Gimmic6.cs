using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gimmic6 : MonoBehaviour
{
    public GameObject Stage6_human;
    public Sprite Stage6_nohuman;
    public GameObject Stage2_deadhuman;
    public Sprite Stage2_nodeadhuman;
    public GameObject Stage1_nodrum;
    public Sprite Stage1_drum;
    public GameObject DrumB;
    public static bool hasInjector = false;
    private SearchButton SearchB;
    public Sprite Injector;
    public GameObject Lighter;
    public GameObject nowItem;
    private Image nowitem;
    private AudioSource audioSource;
    public AudioClip se;
    // Start is called before the first frame update
    void Start()
    {
        SearchB = GetComponent<SearchButton>();
        Lighter.SetActive(false);
        DrumB.SetActive(false);
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        nowitem = nowItem.GetComponent<Image>();
      if(nowitem.sprite == Injector){
          hasInjector = true;
           SearchB.outcome = "！！！";    
        }else if(ItemBox.instance.usedinjector == false){
          hasInjector = false;
          SearchB.outcome = "とてつもなく臭い..."; 
        }
    }

//注射器を持っていたら人間に刺す
    public void OnClickGimmic6(){
         bool hasItem = ItemBox.instance.CanUseItem(Item.ItemType.Injector);

         if(hasItem == true && hasInjector == true){
          audioSource.PlayOneShot(se);
          Stage6_human.GetComponent<Image>().sprite = Stage6_nohuman;
          ItemBox.instance.UseItem(Item.ItemType.Injector);
          nowitem.color = new Color(255,255,255,0f);
          Lighter.SetActive(true);
          Stage1_nodrum.GetComponent<Image>().sprite = Stage1_drum;
          DrumB.SetActive(true);
          Stage2_deadhuman.GetComponent<Image>().sprite = Stage2_nodeadhuman;
        }
    }
}
