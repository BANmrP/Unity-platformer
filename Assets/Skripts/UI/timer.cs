using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class timer : MonoBehaviour
{
    public TextMeshProUGUI Timer;
    public TextMeshProUGUI Record;

    public float sec = 0;
    public float secRecord = 0;

    void Start()
    {
        Timer.text = sec.ToString();
    }

    void Update()
    {
        sec += Time.deltaTime;
        
        secRecord = sec;

        if(PlayerPrefs.GetFloat("score") <= secRecord)
        {
            PlayerPrefs.SetFloat("score", secRecord);
        }

        Record.text = PlayerPrefs.GetFloat("score").ToString();
        Timer.text = sec.ToString();
    }
}