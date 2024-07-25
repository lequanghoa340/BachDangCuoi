using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveRANDOM : MonoBehaviour
{
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    public float speed = 1.0f;
    public float stopDistance = 0.1f; // Khoảng cách ngưỡng để dừng di chuyển

    void Start()
    {
        // Di chuyển GameObject đến vị trí ngẫu nhiên ban đầu
        RandomizePosition();
    }

    void Update()
    {
        // Di chuyển GameObject đến vị trí ngẫu nhiên mới liên tục
        RandomizePosition();
    }

    void RandomizePosition()
    {
        // Tạo vị trí ngẫu nhiên trong phạm vi đã xác định
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        // Tính toán vị trí mới dựa trên tốc độ di chuyển và Time.deltaTime
        Vector3 newPosition = new Vector3(randomX, randomY, transform.position.z);

        // Di chuyển từ vị trí hiện tại đến vị trí ngẫu nhiên
        transform.position = Vector3.MoveTowards(transform.position, newPosition, speed * Time.deltaTime);

        // Kiểm tra xem có đến vị trí ngẫu nhiên hay không
        if (Vector3.Distance(transform.position, newPosition) <= stopDistance)
        {
            // Dừng di chuyển
            speed = 0.0f;
        }
    }
}
