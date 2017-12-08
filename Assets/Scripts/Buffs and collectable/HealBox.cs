using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealBox : MonoBehaviour {

    public GameObject healBox;
    public PlayerMovement playerHealth;
    public Collider2D colliderCheck;
    //variables for player health and item

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (playerHealth.health < GameController.control.maxHealth)
            {
                if (healBox != null)
                {
                    playerHealth.health += 1;
                    Destroy(healBox);
                    Destroy(colliderCheck);
                    //remove collider 
                }

            }
        }

        //if player enters trigger area and if the players health is less than maximum
        //add 1 health and destroy healBox item
       
    }

}
