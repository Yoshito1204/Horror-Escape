using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gimmic2 : MonoBehaviour
{
    public GameObject Stage2_noladder;
    public Sprite Stage2_ladder;
    public static bool hasLadder = false;
    private SearchButton SearchB;
    public GameObject YaneuraB;
    public GameObject OperationB;
    public Sprite Ladder;
    public GameObject nowItem;
    private Image nowitem;
    private AudioSource audioSource;
    public AudioClip hasigo;

    // Start is called before the first frame update
    void Start()
    {
        SearchB = GetComponent<SearchButton>();
        YaneuraB.SetActive(false);
        OperationB.SetActive(false);
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        nowitem = nowItem.GetComponent<Image>();
      if(nowitem.sprite == Ladder){
          hasLadder = true;
           SearchB.outcome = "はしごを立てかけた。";    
        }else if(ItemBox.instance.usedladder == false){
          hasLadder = false;
          SearchB.outcome = "上向きの矢印が書いてある";
        }
    }

//はしごを持っていたら壁に立てかける
    public void OnClickGimmic2(){
　　　　bool hasItem = ItemBox.instance.CanUseItem(Item.ItemType.Ladder);

　　　　if(hasItem == true && hasLadder == true){
          Stage2_noladder.GetComponent<Image>().sprite = Stage2_ladder;
          ItemBox.instance.UseItem(Item.ItemType.Ladder);
          nowitem.color = new Color(255,255,255,0f);
          audioSource.PlayOneShot(hasigo,0.5f);
        }
        if(ItemBox.instance.usedladder == true){
            SearchB.outcome = "";
           SearchB.ImageText.SetActive(false);
            YaneuraB.SetActive(true);
            OperationB.SetActive(true);
            audioSource.PlayOneShot(hasigo,0.5f);
             PanelChanger.instance.ShowPanel(PanelChanger.Panel.Panel10);
        }
    }
}
