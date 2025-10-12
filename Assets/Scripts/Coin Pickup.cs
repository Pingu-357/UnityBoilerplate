using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    public int score;
    void OnTriggerEnter()
    {
         if (CompareTag("Player"))
        { 
            Destroy(gameObject);
        }
    }
}
