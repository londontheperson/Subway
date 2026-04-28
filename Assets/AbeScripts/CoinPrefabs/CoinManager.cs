using UnityEngine;
using System.Collections.Generic;

public class CoinManager : MonoBehaviour
{

public static CoinManager Instance {get; private set;}
public int coins = 0;

private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
       
       Instance = this;

       DontDestroyOnLoad(gameObject);
    }

 // Add coins from anywhere in the scene.
    public void AddCoin(int coinsToAdd)
    {
        if (coinsToAdd == 0) return;
        coins += coinsToAdd;
        if (coins < 0) coins = 0; // clamp to zero
        Debug.Log($"Added {coinsToAdd} coins (total: {coins})");
    }

    // Remove coins from anywhere in the scene.
    public void RemoveCoin(int coinsToRemove)
    {
        if (coinsToRemove == 0) return;
        coins -= coinsToRemove;
        if (coins < 0) coins = 0; // clamp to 0
        Debug.Log($"Removed {coinsToRemove} coins (total: {coins})");
    }

}
