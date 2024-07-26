using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maukedich : MonoBehaviour
{
    public int hp = 50;
    int coinx;
    bool watCalled = false; 

    int ifwin = 0;

    Animator animator;

    AudioManager audioManager;

    // Update is called once per frame
    private void Start()
    {
        animator = GetComponent<Animator>();
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    void Update()
    {
        if (hp <= 0)
        {
            if (!watCalled) // Check if wat has already been called
            {
                animator.SetBool("des", true);
                Invoke("wat", 0.5f);
                watCalled = true; // Set flag to true after invoking wat
                audioManager.PlaySFX(audioManager.vothuyen);
            }
        }

    }

    void wat()
    {
        coinx = PlayerPrefs.GetInt("coin");
        coinx += 50;
        PlayerPrefs.SetInt("coin", coinx);
        ifwin = PlayerPrefs.GetInt("win");
        ifwin++;
        PlayerPrefs.SetInt("win", ifwin);

        PlayerPrefs.Save();

        Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
            if (collision.gameObject.tag=="cungten")
        {
            hp -= 20;
        }
            if (collision.gameObject.tag == "cocgo")
        {
            hp = hp / 2;
        }
        if (collision.gameObject.tag == "bulletNgoQuyen")
        {
            hp = 0;
        }
    }

   
}
