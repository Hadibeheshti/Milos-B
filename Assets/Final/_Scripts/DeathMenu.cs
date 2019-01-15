using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;
    public GameObject deathMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (GameIsPaused)
            {
                PlayAgain();

            }
            else
            {
                Pause();
            }
        }
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene("PaulG2");
        deathMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }


    void Pause()
    {
        deathMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu"); //harcode, plx fix to variable as seen in main menu
    }
    public void QuitGame()
    {
        Debug.Log("Quitting game..");
        Application.Quit();
    }
}
