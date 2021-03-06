using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pickup : MonoBehaviour
{
    public enum PickupType {Key, Coin}
    public PickupType currentPickup;
    public int pickupAmount;
    private PlayerController playerController;
    public TextMeshProUGUI coinCounterText; //the text itself


    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            if(currentPickup == PickupType.Key)
            {
                playerController.key = pickupAmount; //just = since there's only one
                Debug.Log("You picked up a key!");
            }
            else if(currentPickup == PickupType.Coin)
            {
                playerController.coins += pickupAmount;
                //UpdateCoinCounter(playerController.coins);
               Debug.Log("You picked up " + pickupAmount + " Coins.");
            }
            Destroy(gameObject);
        }
    }

    
}
