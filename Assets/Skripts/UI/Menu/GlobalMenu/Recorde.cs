using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Recorde : MonoBehaviour
{
    public static float time = 0;

    public TextMeshProUGUI Record;

    void Start()
    {
        Record.text = PlayerPrefs.GetFloat("score").ToString();
    }
}
