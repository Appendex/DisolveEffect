using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coin : MonoBehaviour
{
    private float coin = 0f;
    public TextMeshProUGUI textCoins;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Coin")
        {
            coin++;
            textCoins.text = coin.ToString();

            Destroy(collision.gameObject);
        }
    }
}
