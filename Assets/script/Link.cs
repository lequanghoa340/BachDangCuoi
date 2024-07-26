using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Link : MonoBehaviour
{
   public GameObject cancelx;
    public void OpenYouWed()
    {
        Application.OpenURL("https://bachdangsu.site/");
    }

    public void cancel()
    {
        cancelx.SetActive(false);
    }
}
