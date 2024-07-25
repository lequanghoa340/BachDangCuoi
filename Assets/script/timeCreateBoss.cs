using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeCreateBoss : MonoBehaviour
{
    float time = 63f;
    public GameObject enemy;
    public GameObject boss;


    private void Update()
    {
        time -= Time.deltaTime;
        if (time < 0)
        {
            enemy.SetActive(false);
            boss.SetActive(true);
        }
    }


}
