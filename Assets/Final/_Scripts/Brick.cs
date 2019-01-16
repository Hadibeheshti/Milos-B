using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public bool hasCoin;
    public GameObject coinPrefab;
    public  float coinOffset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnKill()
    
        {
        if (hasCoin)
        {
           GameObject coinObject =  GameObject.Instantiate(coinPrefab);
            coinObject.transform.position = transform.position + new Vector3(0f, coinOffset, 0f);
            Coin coin = coinObject.GetComponent<Coin>();
            coin.Vanish();
            GameObject.Find("Player").GetComponent<Player>().onCollectCoin();


        }


     }

    }
