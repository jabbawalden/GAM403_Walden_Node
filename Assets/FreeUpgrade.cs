using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeUpgrade : MonoBehaviour {

    public GameObject freeUpgradeBox;

    void Update()
    {
        if (GameController.control.freeUpgrade == false)
        {
            Destroy(freeUpgradeBox);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))

        {
            if (GameController.control.freeUpgrade == true)
            {
                
                GameController.control.techCollected += 15;
                GameController.control.freeUpgrade = false;
            }

        }
    } 
   
}



