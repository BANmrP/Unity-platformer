using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsControl : MonoBehaviour
{
    public GameObject Settings;
    
    public Toggle toggle;

    public static bool music = true;
    public bool mus;

    public int musicSave = 1;

    void Start()
    {
        Settings.SetActive(false);
        musicSave = PlayerPrefs.GetInt("music");

        if (musicSave == 1)
        {
            music = true;
        }
        else
        {
            music = false;
        }
    }

    void Update()
    {
        toggle.isOn = music;
        mus = music;
    }

    public void Open()
    {
        Settings.SetActive(true);
    }

    public void Exit()
    {
        Settings.SetActive(false);
    }

    public void musicSettings()
    {
        if (toggle.isOn == true)
        {
            music = true;
            PlayerPrefs.SetInt("music", music ? 1 : 0);
        }

        if (toggle.isOn == false)
        {
            music = false;
            PlayerPrefs.SetInt("music", music ? 1 : 0);
        }
    }
}
