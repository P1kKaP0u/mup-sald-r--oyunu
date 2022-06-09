using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public GameObject pauseMenuUi;

    public void Pause()
    {

        pauseMenuUi.SetActive(true);
        Time.timeScale = 0f;

    }


   public void Resume()
    {
        pauseMenuUi.SetActive(false);
        Time.timeScale = 1f;
    }


    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }


    public void QuitGame()
    {
        Debug.Log("ÇIKIÞ YAPILDI");
        Application.Quit();
    }

    


}
