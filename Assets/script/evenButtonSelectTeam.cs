using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class evenButtonSelectTeam : MonoBehaviour
{
    public GameObject CavasA;
    public GameObject CavasB;
  
    public void seletA()
    {
        CavasA.SetActive(!CavasA.activeSelf);
    }
    public void seletB()
    {
        CavasB.SetActive(!CavasB.activeSelf);
    }


}
