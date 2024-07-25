using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class thanhmau : MonoBehaviour
{

    public Image _thanhmau;


    public void capnhatthanhmau(float luongmauhientai , float luongmautoida)
    {
        _thanhmau.fillAmount = luongmauhientai/ luongmautoida ;
    }
    
}
