using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public GameObject Choice;

    void Start()
    {
        Choice.SetActive(false);
    }

    public void exit()
    {
        Application.Quit();
    }   

    public void Delete()
    {
        Choice.SetActive(true);
    }

    public void DeleteData()
    {
        PlayerPrefs.DeleteAll();
        Score.coin = 0;
        SettingsControl.music = true;
        Choice.SetActive(false);
    }

    public void Cancel()
    {
        Choice.SetActive(false);
    }
}