using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muiten : MonoBehaviour
{
    float timeDestroy = 4;

    private void Update()
    {
        timeDestroy-=Time.deltaTime;
        if (timeDestroy < 0)
        {
            Destroy(this.gameObject);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ( collision.gameObject.tag=="KeDich")
        {
            Destroy( this.gameObject );
        }
    }

}
