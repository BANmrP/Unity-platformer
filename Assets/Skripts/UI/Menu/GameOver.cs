using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject OverMenu;
    public GameObject SkriptObject;

    public Controler PlayerControl;

    public TimeSkyle time;

    void Start()
    {
        OverMenu.SetActive(false);
        time = SkriptObject.GetComponent<TimeSkyle>();
        PlayerControl.enabled = true;       
    }

    void Update()
    {
        if (XP.xp <= 0)
        {           
            PlayerControl.enabled = false;
            OverMenu.SetActive(true);
            Time.timeScale = 0;
            time.Scale = 0;
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
        XP.xp = 1;
        OverMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
        XP.xp = 1;
        OverMenu.SetActive(false);       
    }
}
