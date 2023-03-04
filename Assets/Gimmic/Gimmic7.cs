using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gimmic7 : MonoBehaviour
{
    public GameObject LastSelect;
    public GameObject LastYurei;
    private GameObject MapB;
    private GameObject ItemB;
    private GameObject NowUseB;
    private GameObject ImageText;
    private AudioSource audioSource;
    public static bool IsYes;
    public static bool hasLighter = false;
    private SearchButton SearchB;
    public Sprite Lighter;
    public GameObject nowItem;
    private Image nowitem;

    private void Awake() {
        LastSelect.SetActive(false);
       // LastYurei = GameObject.Find("lastyuurei");
        MapB = GameObject.Find("MapBoxButton");
        ItemB = GameObject.Find("ItemBoxButton");
        NowUseB = GameObject.Find("UsingItem");
        ImageText = GameObject.Find("TextImage");
        SearchB = GetComponent<SearchButton>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
        IsYes = false;
        audioSource = GetComponent<AudioSource>();
        LastYurei.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
          nowitem = nowItem.GetComponent<Image>();
      if(nowitem.sprite == Lighter){
          hasLighter = true;
          //SearchB.outcome = "はしごを立てかけた。";    
        }
    }

    public void OnClickGimmic7(){
        bool hasItem = ItemBox.instance.CanUseItem(Item.ItemType.Lighter);

        if(hasItem == true && hasLighter == true){
            LastSelect.SetActive(true);
        ImageText.SetActive(false);
        }

        
    }

    public void No(){
        LastSelect.SetActive(false);
        ImageText.SetActive(false);
    }

    public void Yes(){
       StartCoroutine("PressYes");
    }

    IEnumerator PressYes(){
         audioSource.PlayOneShot(audioSource.clip);
        LastSelect.GetComponent<Image>().color = new Color(255,255,255,0f);
        LastSelect.transform.GetChild(0).GetComponent<Text>().color = new Color(255,255,255,0f);
        LastSelect.transform.GetChild(1).localPosition = new Vector3(0,1500,0);
        LastSelect.transform.GetChild(2).localPosition = new Vector3(0,1500,0);
        ImageText.SetActive(false);
        MapB.SetActive(false);
        ItemB.SetActive(false);
        NowUseB.SetActive(false);
        PanelChanger.instance.rightArrow.SetActive(false);
        PanelChanger.instance.leftArrow.SetActive(false);
        LastYurei.SetActive(true);
        IsYes = true;

        yield return new WaitForSeconds(4);

        SceneManager.LoadScene("Ending");
    }
}
