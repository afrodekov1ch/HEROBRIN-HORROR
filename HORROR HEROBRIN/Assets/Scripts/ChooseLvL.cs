using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChooseLvL : MonoBehaviour
{
    private int chooseLvl;
    private int[] saveChoose;

    private void Update()
    {
        saveChoose[0] = PlayerPrefs.GetInt("lvl1");
        saveChoose[1] = PlayerPrefs.GetInt("lvl2");
        saveChoose[2] = PlayerPrefs.GetInt("lvl3");
        saveChoose[3] = PlayerPrefs.GetInt("lvl4");
        saveChoose[4] = PlayerPrefs.GetInt("lvl5");
        saveChoose[5] = PlayerPrefs.GetInt("lvl6");
        saveChoose[6] = PlayerPrefs.GetInt("lvl7");
        saveChoose[7] = PlayerPrefs.GetInt("lvl8");
        saveChoose[8] = PlayerPrefs.GetInt("lvl9");
        saveChoose[9] = PlayerPrefs.GetInt("lvl10");
    }
    public void LoadScene(int lvl)
    {
        chooseLvl = Random.Range(3, 17);
        if (lvl == 1)
        {
            PlayerPrefs.SetInt("lvl1", chooseLvl);   
            SceneManager.LoadScene(chooseLvl);
        }
        if (lvl == 2 && saveChoose[0] != chooseLvl)
        {
            PlayerPrefs.SetInt("lvl2", chooseLvl);
            SceneManager.LoadScene(chooseLvl);
        }
        if (lvl == 3 && saveChoose[0] != chooseLvl && saveChoose[1] != chooseLvl)
        {
            PlayerPrefs.SetInt("lvl3", chooseLvl);
            SceneManager.LoadScene(chooseLvl);
        }
        if (lvl == 4 && saveChoose[0] != chooseLvl && saveChoose[1] != chooseLvl && saveChoose[2] != chooseLvl && saveChoose[3] != chooseLvl)
        {
            PlayerPrefs.SetInt("lvl4", chooseLvl);
            SceneManager.LoadScene(chooseLvl);
        }
        if (lvl == 5 && saveChoose[0] != chooseLvl && saveChoose[1] != chooseLvl && saveChoose[2] != chooseLvl && saveChoose[3] != chooseLvl && saveChoose[4] != chooseLvl)
        {
            PlayerPrefs.SetInt("lvl5", chooseLvl);
            SceneManager.LoadScene(chooseLvl);
        }
        if (lvl == 6 && saveChoose[0] != chooseLvl && saveChoose[1] != chooseLvl && saveChoose[2] != chooseLvl && saveChoose[3] != chooseLvl && saveChoose[4] != chooseLvl && saveChoose[5] != chooseLvl)
        {
            PlayerPrefs.SetInt("lvl6", chooseLvl);
            SceneManager.LoadScene(chooseLvl);
        }
        if (lvl == 7 && saveChoose[0] != chooseLvl && saveChoose[1] != chooseLvl && saveChoose[2] != chooseLvl && saveChoose[3] != chooseLvl && saveChoose[4] != chooseLvl && saveChoose[5] != chooseLvl && saveChoose[6] != chooseLvl)
        {
            PlayerPrefs.SetInt("lvl7", chooseLvl);
            SceneManager.LoadScene(chooseLvl);
        }
        if (lvl == 8 && saveChoose[0] != chooseLvl && saveChoose[1] != chooseLvl && saveChoose[2] != chooseLvl && saveChoose[3] != chooseLvl && saveChoose[4] != chooseLvl && saveChoose[5] != chooseLvl && saveChoose[6] != chooseLvl && saveChoose[7] != chooseLvl)
        {
            PlayerPrefs.SetInt("lvl8", chooseLvl);
            SceneManager.LoadScene(chooseLvl);
        }
        if (lvl == 9 && saveChoose[0] != chooseLvl && saveChoose[1] != chooseLvl && saveChoose[2] != chooseLvl && saveChoose[3] != chooseLvl && saveChoose[4] != chooseLvl && saveChoose[5] != chooseLvl && saveChoose[6] != chooseLvl && saveChoose[7] != chooseLvl && saveChoose[8] != chooseLvl)
        {
            PlayerPrefs.SetInt("lvl9", chooseLvl);
            SceneManager.LoadScene(chooseLvl);
        }
        if (lvl == 10 && saveChoose[0] != chooseLvl && saveChoose[1] != chooseLvl && saveChoose[2] != chooseLvl && saveChoose[3] != chooseLvl && saveChoose[4] != chooseLvl && saveChoose[5] != chooseLvl && saveChoose[6] != chooseLvl && saveChoose[7] != chooseLvl && saveChoose[8] != chooseLvl && saveChoose[9] != chooseLvl)
        {
            PlayerPrefs.SetInt("lvl10", chooseLvl);
            SceneManager.LoadScene(chooseLvl);
        }

    }
}

