using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class createEnemy : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject enemy;

    private float timecreate = 8f;
    public int enemyint;



    void Update()
    {
        timecreate -= Time.deltaTime;
        if (timecreate < 0 && enemyint>0)
        {
            // Bắn viên đạn
            FireBullet();
            timecreate = 8f;
            enemyint -=1;
        }

    }
    void FireBullet()
    {


        // Tạo viên đạn mới
        GameObject bullet = Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);

        
    }
}
