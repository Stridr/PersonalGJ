using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    [SerializeField] private GameObject winscreen;
    
    
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {


            Cursor.visible = true;
            winscreen.SetActive(true);
            Time.timeScale = 0f;

        }
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
