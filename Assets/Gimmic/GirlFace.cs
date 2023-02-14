using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlFace : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       if (SystemInfo.supportsVibration)
        {
           Handheld.Vibrate();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
