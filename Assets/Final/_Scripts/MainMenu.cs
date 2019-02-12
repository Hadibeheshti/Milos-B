using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene("GoldMaster_E");
        Time.timeScale = 1f;// bestimmtes level nach namen laden
        //SceneManager.LoadScene(1) level 1 auf index laden
        //SceneManager.GetActiveScene().buildIndex + 1); nächstes lvl laden
    }
    public void QuitGame ()
    {
        Debug.Log ("QUIT!");
        Application.Quit();
    }
}
