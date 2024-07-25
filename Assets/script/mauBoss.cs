using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mauBoss : MonoBehaviour
{
    public GameObject win;
    public thanhmau thanhmau;
    public float luongmauhientai;
    public float luongmautoida = 20f;





    private void Start()
    {
        luongmauhientai = luongmautoida;
        thanhmau.capnhatthanhmau(luongmauhientai, luongmautoida);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bulletNgoQuyen")
        {
            luongmauhientai -= 1;
            thanhmau.capnhatthanhmau(luongmauhientai, luongmautoida);

        }
        if (luongmauhientai < 0)
        {
            win.SetActive(true);
        }
    }

}
