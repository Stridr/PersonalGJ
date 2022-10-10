using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject PauseMenuUI;



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            } else
            {
                Pause();
            }

        }
    }

    public void Resume()
    {

        GameIsPaused = false;
        Cursor.visible = false;
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1;


    }

    void Pause()
    {
        
        GameIsPaused = true;
        PauseMenuUI.SetActive(true);
        Cursor.visible = true;
        Time.timeScale = 0;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    
    
}
