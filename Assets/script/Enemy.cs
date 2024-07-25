using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public float speed = 2.0f;

  

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

   
}
