using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Active : MonoBehaviour
{
    public GameObject A;
    // Start is called before the first frame update
    void Start()
    {
        A.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PressMe(){
        A.SetActive(true);
    }
}
