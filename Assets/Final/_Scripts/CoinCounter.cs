using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour


{
    public int coin = 0;
    public static CoinCounter instance = null;

    //[Header("UI")]
    public Text coinText;
    public GameObject gameOver;
    //public GameObject youWon;


    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        coinText.text = coin.ToString();
        gameOver.SetActive(false);
        //youWon.SetActive(false);
    }


    public void GameOver()
    {
        gameOver.SetActive(true);
        print("Game Over");
    }
    //void CheckGameOver()
    //{
    //    if (coin > 3)
    //    {
    //        youWon.SetActive(true);
    //        print("You Won!!!");
    //        Invoke("Reset", resetDelay);  //"reset" in anführungszeichen weil invoke nach dem string im script sucht, dadurch auch recht langsam
    //    }

    //    if (lives < 1)
    //    {
    //        gameOver.SetActive(true);
    //        print("Game Over");
    //        Invoke("Reset", resetDelay); //führt Funktion Reset verzögert aus
    //    }
    //}
    //void Reset()
    //{
    //    SceneManager.LoadScene("PaulTest");
    //}


    //void Start()
    //{
    //    coinText.text = coin.ToString();
    //}


    public void CoinDestroyed()
    {
        coin += 1;
        coinText.text = coin.ToString() ;
    }
}
