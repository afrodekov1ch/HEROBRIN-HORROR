using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public void LoadScene(int lvl)
    {
        SceneManager.LoadScene(lvl);
    }
    
}
