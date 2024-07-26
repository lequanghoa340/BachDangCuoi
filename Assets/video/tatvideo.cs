using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tatvideo : MonoBehaviour
{

    float time = 138;
    public GameObject video;
    public GameObject Ingame;
    public GameObject skip;
    int newbie = 0;

    private void Start()
    {
        newbie = PlayerPrefs.GetInt("nguoimoi");
        if(newbie > 0)
        {
            skip.SetActive(false);
            video.SetActive(false);
            Ingame.SetActive(true);
        }
    }
    void Update()
    {
        time-=Time.deltaTime;
        if (time < 0)
        {
            newbie++;
            PlayerPrefs.SetInt("nguoimoi", newbie);
            PlayerPrefs.Save();
            skip.SetActive(false);
            video.SetActive(false);
            Ingame.SetActive(true);
        }
    }
}
