using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeUpgrade : MonoBehaviour {

    //variable
    public GameObject freeUpgradeBox;
    public GameObject techTextFree;

    private void Start()
    {
        techTextFree.SetActive(false);
    }

    void Update()
    {
        //if true, remove box
        if (GameController.control.freeUpgrade == false)
        {
            Destroy(freeUpgradeBox);
  
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
                 
                GameController.control.techCollected += 30;
                GameController.control.freeUpgrade = false;
                techTextFree.SetActive(true);
        
            }

        }
    } 
   
}



