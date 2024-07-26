using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class coin : MonoBehaviour
{
    public TextMeshProUGUI textcoin;
    public int ccoin;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("coin", ccoin);
    }

    // Update is called once per frame
    void Update()
    {
        ccoin = PlayerPrefs.GetInt("coin");
        if (ccoin < 0)
        {
            ccoin = 0;
            PlayerPrefs.SetInt("coin", ccoin);
        }
        textcoin.text = "" + ccoin;
    }

}
