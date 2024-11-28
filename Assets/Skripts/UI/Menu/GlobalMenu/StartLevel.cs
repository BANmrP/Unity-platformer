using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartLevel : MonoBehaviour
{
   public void start()
   {
        XP.xp = 1;
        SceneManager.LoadScene("SampleScene");
   }
}
