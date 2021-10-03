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
    public Eye_Detector eye;

    public void Start()
    {
        actualTime = 0;
        initialTime = Time.deltaTime;
        Debug.Log("Inicio");
    }

    public void Update(){
        countTime(timeLimit);
    }

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

    private void countTime(float limit){
        actualTime += Time.deltaTime;
        Debug.Log(actualTime);

        if (actualTime > limit)
        {
            Debug.Log("Restart");
            player.StartCoroutine("restartLevel");
            eye.Detect();
        }
    }
}
