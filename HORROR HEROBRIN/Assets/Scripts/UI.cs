using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    private int[] lvls = { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

    //private void Update()
    //{
    //    lvls[0] = PlayerPrefs.GetInt("lvl0");
    //    lvls[1] = PlayerPrefs.GetInt("lvl1");
    //    lvls[2] = PlayerPrefs.GetInt("lvl2");
    //    lvls[3] = PlayerPrefs.GetInt("lvl3");
    //    lvls[4] = PlayerPrefs.GetInt("lvl4");
    //    lvls[5] = PlayerPrefs.GetInt("lvl5");
    //    lvls[6] = PlayerPrefs.GetInt("lvl6");
    //    lvls[7] = PlayerPrefs.GetInt("lvl7");
    //    lvls[8] = PlayerPrefs.GetInt("lvl8");
    //    lvls[9] = PlayerPrefs.GetInt("lvl9");
    //}
    public void LoadScene(int lvl)
    {
        switch(lvl)
        {
            case 0:
                SceneManager.LoadScene(lvls[PlayerPrefs.GetInt("lvl0")]);
                break;
            case 1:
                SceneManager.LoadScene(lvls[PlayerPrefs.GetInt("lvl1")]);
                break;
            case 2:
                SceneManager.LoadScene(lvls[PlayerPrefs.GetInt("lvl2")]);
                break;
            case 3:
                SceneManager.LoadScene(lvls[PlayerPrefs.GetInt("lvl3")]);
                break;
            case 4:
                SceneManager.LoadScene(lvls[PlayerPrefs.GetInt("lvl4")]);
                break;
            case 5:
                SceneManager.LoadScene(lvls[PlayerPrefs.GetInt("lvl5")]);
                break;
            case 6:
                SceneManager.LoadScene(lvls[PlayerPrefs.GetInt("lvl6")]);
                break;
            case 7:
                SceneManager.LoadScene(lvls[PlayerPrefs.GetInt("lvl7")]);
                break;
            case 8:
                SceneManager.LoadScene(lvls[PlayerPrefs.GetInt("lvl8")]);
                break;
            case 9:
                SceneManager.LoadScene(lvls[PlayerPrefs.GetInt("lvl9")]);
                break;
            case 10:
                SceneManager.LoadScene(2);
                break;
        }
    }
    
}
