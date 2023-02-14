using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    //public AudioClip get;
    

    private void Start() {
        
    }
    public enum ItemType
    {
         Hummer,
        Ladder,
        Sudoku,
        Bar,
        Blood,
        Key,
        Injector,
        Lighter,
    }

    public ItemType type;
    public void OnClickItem(){
        ItemBox.instance.SetItem(type);
        gameObject.SetActive(false);
        
    }
}
