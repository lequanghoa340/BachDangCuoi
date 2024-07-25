using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lucbulletdich : MonoBehaviour
{
    public Rigidbody2D rb;
     float speed = 10f;

    void Start()
    {
        // Set the initial velocity to move left
        rb.velocity = new Vector2(-speed, 0f); // Use velocity for constant movement
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "boat")
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "boss")
        {
            Destroy(this.gameObject);
        }
    }
   
}
