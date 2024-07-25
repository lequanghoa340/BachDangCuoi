using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNgoQuyen : MonoBehaviour
{
    public GameObject gameObjectToMove;
    public float speed = 5f; // Tốc độ di chuyển ban đầu
    public float smoothSpeed = 0.1f; // Tốc độ di chuyển từ từ (giảm dần)

    private float currentSpeed = 0f; // Tốc độ hiện tại (được cập nhật)
    private bool isMovingUp = false; // Đang di chuyển lên
    private bool isMovingDown = false; // Đang di chuyển xuống

    void Update()
    {
        // Kiểm tra các nút bấm được nhấn
        // ... (giữ nguyên phần này)

        // Cập nhật hướng di chuyển
        if (isMovingUp)
        {
            currentSpeed += speed * smoothSpeed;
        }
        else if (isMovingDown)
        {
            currentSpeed -= speed * smoothSpeed;
        }

        // Giới hạn tốc độ tối đa
        currentSpeed = Mathf.Clamp(currentSpeed, -speed, speed);

        // Di chuyển GameObject
        Vector3 targetPosition = gameObjectToMove.transform.position;
        targetPosition.y += currentSpeed * Time.deltaTime;
        gameObjectToMove.transform.position = Vector3.MoveTowards(gameObjectToMove.transform.position, targetPosition, smoothSpeed);

        // Cập nhật trạng thái di chuyển
        if (currentSpeed == 0f)
        {
            isMovingUp = false;
            isMovingDown = false;
        }
    }

    public void StartMovingUp()
    {
        isMovingUp = true;
        isMovingDown = false;
    }

    public void StartMovingDown()
    {
        isMovingUp = false;
        isMovingDown = true;
    }
}
