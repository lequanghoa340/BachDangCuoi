using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulettNgoQuyen : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject bulletPrefab;
    public GameObject loss;

    // Tạo vị trí ngẫu nhiên
   
    private float timefire = 1f;
    private void Start()
    {
        Time.timeScale = 1;
    }
    void Update()
    {
        timefire -= Time.deltaTime;
       

    }
   public void FireBullet()
    {
        if (timefire < 0)
        {

            // Vector2 randomPosition = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));

            // Tạo viên đạn mới
            GameObject bullet = Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation);

            // Set vị trí cho viên đạn
            //bullet.transform.position = randomPosition;
            timefire = 1f;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "bulletboss")
        {
            loss.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
