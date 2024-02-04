using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    public Slider slider;
    public float oldVolume;
    [SerializeField] private GameObject start;

    private void Start()
    {
        PlayerPrefs.SetFloat("volume", 1);
        oldVolume = slider.value;
        if (!PlayerPrefs.HasKey("volume")) slider.value = 1;
        else slider.value = PlayerPrefs.GetFloat("volume");
    }
    private void Update()
    {
        if(oldVolume != slider.value)
        {
            PlayerPrefs.SetFloat("volume", slider.value);
            PlayerPrefs.Save();
            oldVolume = slider.value;
        }
        if(PlayerPrefs.GetFloat("volume") != 1)
        {
            Destroy(start);
        }
    }

}
