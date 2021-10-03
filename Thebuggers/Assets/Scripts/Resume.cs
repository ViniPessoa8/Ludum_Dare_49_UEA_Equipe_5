using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  

public class Resume: MonoBehaviour {  
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public AudioSource backgroundMusic;
    public AudioSource backgroundNoise;
    void Update()
    {
 
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
 
            if (GameIsPaused)
            {
                ResumeButton();
                backgroundMusic.Play();
                backgroundNoise.Play();
            }
            else
            {
                Pause();
                backgroundMusic.Pause();
                backgroundNoise.Pause();
            }
        }
    }

    public void ResumeButton() 
    {  
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }  
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
} 
