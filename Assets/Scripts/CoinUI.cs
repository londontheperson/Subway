using UnityEngine;
using TMPro;

public class CoinUI : MonoBehaviour
{
private TMP_Text label;
private int lastCoins = -1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        label = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //Coin Manager var
        var cm = CoinManager.Instance;

        //if no manager, stop
        if(!cm) return;

        //grab current coins from manager
        int coins = cm.coins;

        //update Coins
        if(coins != lastCoins)
        {
            lastCoins = coins;
            label.text =  $"Coins: {coins}";
        }


    }
}
