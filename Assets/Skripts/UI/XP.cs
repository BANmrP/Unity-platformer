using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XP : MonoBehaviour
{
    
    public static float xp = 1;

    public Slider XPrang; 

    void Start()
    {
        
    }

    void Update()
    {
        XPrang.value = xp;
    }
}
