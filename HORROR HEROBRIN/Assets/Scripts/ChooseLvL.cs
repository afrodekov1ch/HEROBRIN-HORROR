using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseLvL : MonoBehaviour
{
    public int[] myArray;

    void Awake()
    {
        myArray = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        for (int i = myArray.Length - 1; i > 0; i--)
        {
            int randomIndex = Random.Range(0, i + 1);
            int temp = myArray[i];
            myArray[i] = myArray[randomIndex];
            myArray[randomIndex] = temp;
        }
        foreach (var num in myArray)
        {
            Debug.Log(num);
        }
        PlayerPrefs.SetInt("lvl0", myArray[0]);
        PlayerPrefs.SetInt("lvl1", myArray[1]);
        PlayerPrefs.SetInt("lvl2", myArray[2]);
        PlayerPrefs.SetInt("lvl3", myArray[3]);
        PlayerPrefs.SetInt("lvl4", myArray[4]);
        PlayerPrefs.SetInt("lvl5", myArray[5]);
        PlayerPrefs.SetInt("lvl6", myArray[6]);
        PlayerPrefs.SetInt("lvl7", myArray[7]);
        PlayerPrefs.SetInt("lvl8", myArray[8]);
        PlayerPrefs.SetInt("lvl9", myArray[9]);
    }
}

