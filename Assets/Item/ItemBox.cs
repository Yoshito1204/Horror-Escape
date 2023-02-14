using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemBox : MonoBehaviour
{
    public GameObject Box0;
    public GameObject Box1;
    public GameObject Box2;
    public GameObject Box3;
    public GameObject Box4;
    public GameObject Box5;
    public GameObject Box6;
    public GameObject Box7;
    public GameObject Box8;
    public GameObject Box9;
    public Sprite UIMask;
    public GameObject ItemDetail;
    public bool usedhummer;
    public bool usedladder;
    public bool usedsudoku;
    public bool usedbar;
    public bool usedblood;
    public bool usedkey;
    public bool usedinjector;
    public bool usedlighter;

    public List<string> ItemList = new List<string>();

    private AudioSource audioSource;
    
    public static ItemBox instance;

    private void Awake() {
       instance = this;    
    }
    void Start(){
      Box0.SetActive(false);
      Box1.SetActive(false);
      Box2.SetActive(false);
      Box3.SetActive(false);
      Box4.SetActive(false);
      Box5.SetActive(false);
      Box6.SetActive(false);
      Box7.SetActive(false);
      Box8.SetActive(false);
      Box9.SetActive(false);
      usedhummer = false;
      usedladder = false;
      usedsudoku = false;
      usedbar = false;
      usedblood = false;
      usedkey = false;
      usedinjector = false;
      usedlighter = false;

      audioSource = GetComponent<AudioSource>();
    }
    public void SetItem(Item.ItemType type){
         if(type == Item.ItemType.Hummer){
            Box0.SetActive(true);
            audioSource.PlayOneShot(audioSource.clip);
         }
         if(type == Item.ItemType.Ladder){
            Box1.SetActive(true);
             audioSource.PlayOneShot(audioSource.clip);
         }
         if(type == Item.ItemType.Sudoku){
            Box2.SetActive(true);
             audioSource.PlayOneShot(audioSource.clip);
         }
         if(type == Item.ItemType.Bar){
            Box3.SetActive(true);
             audioSource.PlayOneShot(audioSource.clip);
         }
         if(type == Item.ItemType.Blood){
            Box4.SetActive(true);
             audioSource.PlayOneShot(audioSource.clip);
         }
         if(type == Item.ItemType.Key){
            Box5.SetActive(true);
             audioSource.PlayOneShot(audioSource.clip);
         }
         if(type == Item.ItemType.Injector){
            Box6.SetActive(true);
             audioSource.PlayOneShot(audioSource.clip);
         }
         if(type == Item.ItemType.Lighter){
            Box7.SetActive(true);
             audioSource.PlayOneShot(audioSource.clip);
         }
       
    }

    public bool CanUseItem(Item.ItemType type){

        if(type == Item.ItemType.Hummer){
           return Box0.activeSelf;
        }else if(type == Item.ItemType.Ladder){
           return Box1.activeSelf;
        }else if(type == Item.ItemType.Sudoku){
            return Box2.activeSelf;
        }else if(type == Item.ItemType.Bar){
            return Box3.activeSelf;
        }else if(type == Item.ItemType.Blood){
            return Box4.activeSelf;
        }else if(type == Item.ItemType.Key){
            return Box5.activeSelf;
        }else if(type == Item.ItemType.Injector){
            return Box6.activeSelf;
        }else if(type == Item.ItemType.Lighter){
            return Box7.activeSelf;
        }
        return false;
    }

    public void UseItem(Item.ItemType type){
        if(type == Item.ItemType.Hummer){
            Box0.SetActive(false);
            Reset();
            usedhummer = true;
            ItemList.Clear();
         }
         if(type == Item.ItemType.Ladder){
            Box1.SetActive(false);
            Reset();
            usedladder = true;
            ItemList.Clear();
         }
         if(type == Item.ItemType.Sudoku){
            Box2.SetActive(false);
            Reset();
            usedsudoku = true;
            ItemList.Clear();
         }
          if(type == Item.ItemType.Bar){
            Box3.SetActive(false);
            Reset();
            usedbar = true;
            ItemList.Clear();
         }
          if(type == Item.ItemType.Blood){
            Box4.SetActive(false);
            Reset();
            usedblood = true;
            ItemList.Clear();
         }
          if(type == Item.ItemType.Key){
            Box5.SetActive(false);
            Reset();
            usedkey = true;
            ItemList.Clear();
         }
          if(type == Item.ItemType.Injector){
            Box6.SetActive(false);
            Reset();
            usedinjector = true;
            ItemList.Clear();
         }
          if(type == Item.ItemType.Lighter){
            Box7.SetActive(false);
            Reset();
            usedlighter = true;
            ItemList.Clear();
         }
    }

    public void Reset(){
      ItemDetail.transform.GetChild(0).GetComponent<Image>().sprite = UIMask;
            ItemDetail.transform.GetChild(1).GetComponent<Text>().text = "";
            ItemDetail.transform.GetChild(2).GetComponent<Text>().text = "アイテムを選択して....";
    }
}
