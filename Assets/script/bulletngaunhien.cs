using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletngaunhien : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject bulletPrefab;

    // Tạo vị trí ngẫu nhiên
  public  float minX ;
    public float maxX ;
    public float minY ;
    public  float maxY ;
    private float timefire = 4f;
    void Update()
    {
        timefire -= Time.deltaTime;
        if (timefire < 0)
        {
            // Bắn viên đạn
            FireBullet();
            timefire = 4f;
        }
      
    }
    void FireBullet()
    {
      
        Vector2 randomPosition = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));

        // Tạo viên đạn mới
        GameObject bullet = Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation);

        // Set vị trí cho viên đạn
        bullet.transform.position = randomPosition;
    }

    
}
