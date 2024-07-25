using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class eventmain : MonoBehaviour
{
    public GameObject InGame;
    public GameObject video;
    public GameObject Skip;
    public GameObject Level;
    public GameObject openLever;
    AudioManager audioManager;

   
    
 public void PlayGame()
    { 
        openLever.SetActive(true);
         InGame.SetActive(true);
        Level.SetActive(true);
    
    }

    public void skipvideo()
    {
        InGame.SetActive(true);
        video.SetActive(false);
        Skip.SetActive(false);
    }
}
