using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public static bool isPaused;

    private void Start()
    {
        pauseMenu.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        { 
            if(isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }

        }
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0.0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1.0f;
        isPaused = false;
    }

    public void goToMainMenu()
    {
        Time.timeScale = 1.0f;
        isPaused = false;
        SceneManager.LoadScene("Main_Menu");
        
    }

    public void QuitGame()
    {
        Application.Quit(); 
    }
}
