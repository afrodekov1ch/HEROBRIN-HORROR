using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer_ : MonoBehaviour
{
    public float delayInSeconds = 5f;
    public Button specificButton;
    public Image timeBar;
    public GameObject scream;
    public AudioSource ad;

    private void Start()
    {
        StartCoroutine(ShowImageAfterDelay());
    }

    private IEnumerator ShowImageAfterDelay()
    {
        while (delayInSeconds > 0f)
        {
            Debug.Log("Timer: " + delayInSeconds.ToString("F1"));
            yield return new WaitForSeconds(1f);
            delayInSeconds -= 1f;
            timeBar.fillAmount = delayInSeconds / 5f;
        }
        ShowImage();
    }

    private void ShowImage()
    {
        ad.Play();
        scream.SetActive(true);
        Invoke("Restart", 3f);
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
}

