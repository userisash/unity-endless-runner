using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Border"))
        {
            Destroy(gameObject);
        }

        else if (collision.gameObject.CompareTag("Player"))
        {
            CoinScoreManager.instance.ChangeCoinScore(coinValue);
        }
    }

}
