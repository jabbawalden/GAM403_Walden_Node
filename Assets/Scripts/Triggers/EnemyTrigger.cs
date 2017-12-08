using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger : MonoBehaviour {

    public bool playerIsHere;
    

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            print("player is here");
            playerIsHere = true;
            
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            print("player has left");
            playerIsHere = false;
            
        }
    }

    //trigger to detect when player has arrived or left
    //other scripts call upon the bool to check whether or not to fire/attack the player
}
