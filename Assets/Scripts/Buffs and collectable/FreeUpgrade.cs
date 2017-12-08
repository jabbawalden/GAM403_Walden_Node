using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeUpgrade : MonoBehaviour {

    //variable
    public GameObject freeUpgradeBox;
    public BoxCollider2D colliderCheck;

    void Update()
    {
        //if true, remove box
        if (GameController.control.freeUpgrade == false)
        {
            Destroy(freeUpgradeBox);
            Destroy(colliderCheck);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        //if player, increase tech and change freeUpgrade to false.
        //Intended to be a one time only upgrade
        if (collision.gameObject.CompareTag("Player"))

        {
            if (GameController.control.freeUpgrade == true)
            {
                 
                GameController.control.techCollected += 15;
                GameController.control.freeUpgrade = false;
                Destroy(colliderCheck);
            }

        }
    } 
   
}



