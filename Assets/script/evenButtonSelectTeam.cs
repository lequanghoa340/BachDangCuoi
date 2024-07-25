using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class evenButtonSelectTeam : MonoBehaviour
{
    public GameObject CavasA;
    public GameObject CavasB;
  
    public void seletA()
    {
        CavasA.SetActive(true);
    }
    public void seletB()
    {
        CavasB.SetActive(true);
    }
}
