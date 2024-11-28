using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPause : MonoBehaviour
{
    public GameObject PauseMenu;

    private bool pause = false;

    public TimeSkyle time;

    void Start()
    {
        PauseMenu.SetActive(false);

        time = gameObject.GetComponent<TimeSkyle>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pause)
            {
                proceed();
            }
            else
            {
                Pause();
            }
        }
    }

    private void Pause()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0;
        time.Scale = 0;
        pause = true;
    }

    public void proceed()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1;
        time.Scale = 1;
        pause = false;
    }
}
