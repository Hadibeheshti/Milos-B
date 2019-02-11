using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Player player;
    public Text scoreText;
    private int score;
    private float restartTimer = 3f;
    public float gravity = 9.81f;
    public static GameController instance = null;

    // Start is called before the first frame update
    //void Start()
    //{
    //    player.onCollectCoin = OnCollectCoin;



    //}
     
    // Update is called once per frame
    void Update()
    {
        if (player.Dead)
        {
            restartTimer -= Time.deltaTime;
            if (restartTimer <= 0f)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);

            }

        }

        Physics.gravity = new Vector3(0, -gravity, 0);

        
    }

   //public void OnCollectCoin()
   // {
   //     score += 1;
   //     scoreText.text = "Score: " + score;
   // }

}
