using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CoinFinal")
        {

            GameManager.instance.OnCollectCoin();


        }

        /*
        if (other.gameObject.CompareTag("Coin"))
        {
            Debug.Log("coin collected");
            GameManager.instance.OnCollectCoin();
        }
        */
    }
}
