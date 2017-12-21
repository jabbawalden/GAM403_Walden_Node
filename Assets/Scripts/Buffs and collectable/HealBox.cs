using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealBox : MonoBehaviour {

    public GameObject healBox;
    public PlayerMovement playerHealth;
    public GameObject healText;

    //variables for player health and item

    private void Start()
    {
        healText.SetActive(false);
    }

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
                    healText.SetActive(true);
                  
                }

            }
        }

        //if player enters trigger area and if the players health is less than maximum
        //add 1 health and destroy healBox item
       
    }

}
