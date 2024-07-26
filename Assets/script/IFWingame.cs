using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IFWingame : MonoBehaviour
{
    public int Indexmanchoix;
    Spawner spawner;
    createEnemy createEnemy;
    int enemy1;
    int enemy2;
    int enemy;
    int ifwin;
    public GameObject winpanel;
    void Start()
    {
      //  lấy chiến công mà tàu thuyền team bạn chết 
        PlayerPrefs.SetInt("win", 0);

        //lấy tổng số lượng thuyền có trong màn chơi 
        spawner = GameObject.Find("Spawner").GetComponent<Spawner>();
        enemy1 = spawner.maxEnemies;

        createEnemy = GameObject.Find("CreateEnemy").GetComponent<createEnemy>();
        enemy2 = createEnemy.enemyint;

        enemy = enemy1 + enemy2;
        

    }

    // Update is called once per frame
    void Update()
    {
        ifwin = PlayerPrefs.GetInt("win");

        if (ifwin ==enemy )
        {
            PlayerPrefs.SetInt("indexmanchoi", Indexmanchoix);
            PlayerPrefs.Save();
            winpanel.SetActive(true);
        }
        
    }
}
