using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tatvideo : MonoBehaviour
{

    float time = 138;
    public GameObject video;
    public GameObject Ingame;
    public GameObject skip;
   
    void Update()
    {
        time-=Time.deltaTime;
        if (time < 0)
        {
            skip.SetActive(false);
            video.SetActive(false);
            Ingame.SetActive(true);
        }
    }
}
