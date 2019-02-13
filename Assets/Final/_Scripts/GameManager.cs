using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // zum szene laden
using UnityEngine.UI;               // für leben usw

public class GameManager : MonoBehaviour
{

    private float restartTimer = 3f;
    public int coin = 0;

    //public float resetDelay = 3;


    // ui stuff
    [Header("UI")]
    public Text coinText;
    //public GameObject gameOver;
    //public GameObject youWon;
    public static GameManager instance = null;
    // Use this for initialization
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        coinText.text = coin.ToString();
    }
    //gameOver.SetActive(false);
    //youWon.SetActive(false);
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (Input.GetKeyDown(KeyCode.F5))
        {
            Reset();
        }
    }

    void Reset()
    {
        //SceneManager benötigt
        //using UnityEngine.SceneManagement;
        //name der jeweiligen szene
        //SceneManager.LoadScene("Breakout Game Basic");
        restartTimer -= Time.deltaTime;
        if (restartTimer <= 0f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void OnCollectCoin()
    {
        coin +=1;
        coinText.text = coin.ToString();
        Debug.Log("coin added!");
    }
}
