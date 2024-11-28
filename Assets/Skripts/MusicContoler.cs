using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicContoler : MonoBehaviour
{
    public AudioSource musicObject;

    void Start()
    {
        
    }

    void Update()
    {
        musicObject.enabled = SettingsControl.music;
    }
}
