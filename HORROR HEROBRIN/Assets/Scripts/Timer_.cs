using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer_ : MonoBehaviour
{
    public float delayInSeconds = 6f;
    public Button specificButton;
    public Image timeBar;
    public GameObject scream;
    public AudioSource ad;
    public GameObject txt;
    private int health;
 
    private void Start()
    {
        StartCoroutine(ShowImageAfterDelay());
    }
    private void Update()
    {
        health = PlayerPrefs.GetInt("health");
        if(delayInSeconds <= 3)
        {
            txt.SetActive(false);
        }
    }
    private IEnumerator ShowImageAfterDelay()
    {
        while (delayInSeconds > 0f)
        {
            Debug.Log("Timer: " + delayInSeconds.ToString("F1"));
            yield return new WaitForSeconds(1f);
            delayInSeconds -= 1f;
            timeBar.fillAmount = delayInSeconds / 6f;
        }
        ShowImage();
    }

    private void ShowImage()
    {
        ad.Play();
        scream.SetActive(true);
        health -= 1;
        PlayerPrefs.SetInt("health", health);
        Invoke("Restart", 3f);
    }

    public void Restart()
    {
        var index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index + 1);
    }
}

