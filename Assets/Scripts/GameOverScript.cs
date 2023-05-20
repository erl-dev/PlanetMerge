using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public GameObject gameOverCanvas;

    void Start()
    {
        gameOverCanvas.SetActive(false);
        Time.timeScale = 1;
    }


    private void OnTriggerEnter()
    {
        if (OnTriggerDisableScript.onPlayArea == true)
        {
            GameOver();
            OnTriggerDisableScript.onPlayArea = false;
        }
    }

  
    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
        
    }

    public void Replay()
    {
        Debug.Log("Retry");
        Time.timeScale = 1;
       
        SceneManager.LoadScene("Main Game");
        gameOverCanvas.SetActive(false);

    }
}
