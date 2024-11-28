using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public static int coin = 0;
    public TextMeshProUGUI money;

    void Start()
    {
        coin = PlayerPrefs.GetInt("money");
        //coin = 10000;
    }

    void Update()
    {
        money.text = coin.ToString();
        PlayerPrefs.SetInt("money", coin);
    }  
}