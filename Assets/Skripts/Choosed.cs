using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choosed : MonoBehaviour
{
    public int index = 0;

    public GameObject[] items;

    void Start()
    {
        index = PlayerPrefs.GetInt("GoodIndex");

        if (index == 0)
        {           
            Gun.player = items[index].transform;
        }

        if (index == 1)
        {
            items[index].SetActive(true);
            Gun.player = items[index].transform;
            items[0].SetActive(false);
        }
    }
}
