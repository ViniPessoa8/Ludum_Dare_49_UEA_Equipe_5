using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu_Controller : MonoBehaviour
{
    public string nextScene;
    public int timeLimit;
    public GameObject credits;
    public GameObject mainmenu;

    public void exitgame() 
    {  
        Debug.Log("exitgame");  
        Application.Quit();  
    }  

    public void goToNextScene()
    {
        SceneManager.LoadScene(nextScene);
    }

    public void restartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void openCredits(){
        credits.SetActive(true);
        mainmenu.SetActive(false);
    }
}

