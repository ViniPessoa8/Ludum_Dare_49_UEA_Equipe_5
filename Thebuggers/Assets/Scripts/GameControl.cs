using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public string nextScene;
    public int timeLimit;

    private float initialTime;
    public float actualTime;

    public Player player;
    public List<GameObject> allEyes = new List<GameObject>();

    public AudioSource timeEnding;
    public GameObject backgroundFading;
    public void Start()
    {
        actualTime = 0;
        initialTime = Time.deltaTime;
        Debug.Log("Inicio");
    }

    public void Update(){
        if(actualTime >= timeLimit - 31 && actualTime <= timeLimit - 30){
            timeEnding.Play();
            backgroundFading.GetComponent<Background_Fade>().StartCoroutine("FadeTo");
        }
        if(actualTime <= timeLimit){
            countTime(timeLimit);
        }
    }

    public void exitgame() 
    {  
        Debug.Log("exitgame");  
        Application.Quit();  
    }  

    public void goToNextScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }

    public void restartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void countTime(float limit){
        actualTime += Time.deltaTime;

        if (actualTime > limit)
        {
            foreach (GameObject eye in allEyes){
                eye.GetComponent<Eye_Detector>().Detect();
            }
            player.StartCoroutine("restartLevel");
        }
    }

    public void backToMenu(){
        Debug.Log("Menu");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main_Menu");
    }
}
