using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class thelichsu : MonoBehaviour
{
    public GameObject thelichsux;
    public GameObject xem;

    public void mothe()
    {
        thelichsux.SetActive(true);
    }

  public void nhanthe()
    {
        SceneManager.LoadScene(0);
    }

  public void xemthem()
    {
        xem.SetActive(true);
    }

}
