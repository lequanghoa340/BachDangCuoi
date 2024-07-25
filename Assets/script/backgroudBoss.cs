using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroudBoss : MonoBehaviour
{
    private void Update()
    {
        transform.position += new Vector3(-5 * Time.deltaTime, 0);
        if(transform.position.x < -21.26)
        {
            transform.position = new Vector3(21.6f, transform.position.y);
        }
    }


}
