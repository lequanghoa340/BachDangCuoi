using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class butonSelec : MonoBehaviour
{
    public GameObject teamPlayer;
    public GameObject CvaA;
    public GameObject CvaB;
    int coinx;
    public void pickIdex()
    {
        coinx = PlayerPrefs.GetInt("coin");

        // Check if there are enough coins
        if (coinx < 50)
        {
            Debug.Log("Not enough coins to place the boat.");
            CvaA.SetActive(false);
            return;
        }

        if (teamPlayer.activeInHierarchy)
        {
            Debug.Log("Boat is already placed.");
        }
        else
        {
            coinx -= 50;
            PlayerPrefs.SetInt("coin", coinx);
            PlayerPrefs.Save();
            teamPlayer.SetActive(true);
            CvaA.SetActive(false);
            CvaB.SetActive(false);
        }
    }

}
