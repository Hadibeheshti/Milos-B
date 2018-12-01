using UnityEngine;

public class DestroyCoin : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        Coin.instance.CoinDestroyed();
        Destroy(this.gameObject);

    }
}