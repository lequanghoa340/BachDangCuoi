using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class araylistluuthe : MonoBehaviour
{
    public GameObject ma1;
    public GameObject ma2;
    public GameObject ma3;
    public GameObject ma4;
    public GameObject ma5;
    public GameObject ma6;
    public GameObject ma7;

    int manchoicaonhat;
    int manchoihientai;

    // Start is called before the first frame update
    void Start()
    {
        manchoicaonhat = PlayerPrefs.GetInt("indexmancaonhat");
        manchoihientai = PlayerPrefs.GetInt("indexmanchoi");

        if (manchoicaonhat < manchoihientai)
        {
            manchoicaonhat = manchoihientai;
            PlayerPrefs.SetInt("indexmancaonhat", manchoicaonhat);
            PlayerPrefs.SetInt("indexmanchoi", 0);
        }

        // Tạo mảng GameObject
        GameObject[] gos = new GameObject[] { ma1, ma2, ma3, ma4, ma5, ma6, ma7 };

        // Sử dụng vòng lặp for để setActive("false") cho từng GameObject
        for (int i = 0; i <= manchoicaonhat; i++)
        {
            gos[i].SetActive(true);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
