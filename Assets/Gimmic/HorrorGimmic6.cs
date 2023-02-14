using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorrorGimmic6 : MonoBehaviour
{
    public GameObject Profile;
    public bool IsMove;
    public int clicknum;
    public static HorrorGimmic6 instance;

    private void Awake() {
        if(instance == null){
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        IsMove = false;
        clicknum = 0;
        Profile.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OnClickHorror6(){
         clicknum++;
         if(clicknum % 3 == 0){
            IsMove = true;
            Profile.SetActive(true);
         }
    }

}
