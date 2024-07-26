using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2.0f;
    private float originalSpeed;

    void Start()
    {
        originalSpeed = speed;
    }

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("cocgo"))
        {
            StartCoroutine(ReduceSpeedTemporarily());
        }
    }

    IEnumerator ReduceSpeedTemporarily()
    {
        speed = 0.5f;
        yield return new WaitForSeconds(1.0f);
        speed = originalSpeed;
    }
}
