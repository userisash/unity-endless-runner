using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinScoreManager : MonoBehaviour
{
    public static CoinScoreManager instance;
    public TextMeshProUGUI coinDisplay;
    public AudioClip collect;
    private AudioSource audioSource;
    int coins;
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        audioSource = GetComponent<AudioSource>();
    }


    public void ChangeCoinScore(int coinValue)
    {
        coins += coinValue;
        coinDisplay.SetText("X" + coins.ToString());
        audioSource.PlayOneShot(collect);
    }
}
