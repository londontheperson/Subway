using UnityEngine;

public class Coin : MonoBehaviour
{

public int coinValue = 1;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            CoinManager.Instance?.AddCoin(coinValue);
            Destroy(gameObject);
        }
    }

}
