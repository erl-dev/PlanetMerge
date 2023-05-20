using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public GameObject pauseCanvas;

    public void PauseClicked()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            pauseCanvas.SetActive(true);
        }

        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }


    public void Resume()
    {
        Time.timeScale = 1f;
        pauseCanvas.SetActive(false);

    }

    void Pause()
    {
        Time.timeScale = 0f;
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

}
