using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lose : MonoBehaviour
{
    public GameObject loseMenu;

    AudioManager audioManager;

    private void Awake()
    {
        audioManager = audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            loseMenu.SetActive(true);
            Time.timeScale = 0f;
            audioManager.PlaySFX(audioManager.death);
        }
    }
   
}
