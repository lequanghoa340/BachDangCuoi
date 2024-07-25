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
        if (teamPlayer.activeInHierarchy)
        {
            Debug.Log("chỗ này đã có  rồi");
        }
        else
        {
            coinx = PlayerPrefs.GetInt("coin");
            coinx -= 50;
            PlayerPrefs.SetInt("coin", coinx);
            PlayerPrefs.Save();
            teamPlayer.SetActive(true);
            CvaA.SetActive(false);
            CvaB.SetActive(false);
        }

       
    }

}
