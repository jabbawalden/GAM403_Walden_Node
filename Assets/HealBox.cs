using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealBox : MonoBehaviour {

    public GameObject healBox;
    public PlayerMovement playerHealth;

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
                }

            }
        }
       
    }

}
