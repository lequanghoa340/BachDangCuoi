using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bancung : MonoBehaviour
{
    // Prefab của viên đạn
    public GameObject bulletPrefab;

    // Tốc độ di chuyển của viên đạn
     float bulletSpeed = 28f;

    // Vị trí bắn viên đạn
    private Vector3 firePosition;

    int so;
    float CDbancung = 3;
    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    void Update()
    {
        CDbancung-=Time.deltaTime;
        if (Input.GetMouseButtonDown(0)&& CDbancung <0)
        {
            so++;
            Invoke("so0", 0.5f);
            // Kiểm tra xem chuột trái có được nhấn hay không
            if (Input.GetMouseButtonDown(0)&&so==2)
            {
                CDbancung = 3f;
                so = 0;
                // Lấy vị trí chuột
                Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                // Tính toán hướng bắn
                Vector3 direction = mousePosition - transform.position;
                direction.Normalize();

                // Tạo viên đạn mới
                GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

                // Thiết lập hướng và tốc độ cho viên đạn
                bullet.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
                audioManager.PlaySFX(audioManager.fire);

                // Xóa viên đạn sau một thời gian nhất định
                Destroy(bullet, 2f);
            }
        }
    }
    void so0()
    {
        so = 0;
    }

}