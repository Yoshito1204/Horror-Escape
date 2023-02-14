using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kinko : MonoBehaviour
{
    public GameObject DailLock;
  //  public GameObject Bar;

    // Start is called before the first frame update
    void Start()
    {
        DailLock.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnKinko(){
        DailLock.SetActive(true);
    }
}
