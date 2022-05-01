using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; //textmeshpro

public class CoinCounter : MonoBehaviour
{
    public TextMeshProUGUI coinCounterText; //the text itself

    public void UpdateCoinCounter()
    {
       // coinCounterText = GetComponent<TMP_Text>();
      //  int coins = GetComponent<Pickup>().playerController.coins; //gets the amount of coins picked up?

      //  coinCounterText.text = "Coins: " + coins;
        //why is this so confusing
    }
}
