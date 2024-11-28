using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stading : MonoBehaviour
{
    public GameObject menu;

    void Start()
    {
        menu.SetActive(false);
    }

    void Update()
    {
        
    }

    public void HowPlay()
    {
        menu.SetActive(true);
    }

    public void Ok()
    {
        menu.SetActive(false);
    }
}
