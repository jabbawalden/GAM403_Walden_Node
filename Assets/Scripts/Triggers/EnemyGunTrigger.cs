using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGunTrigger : MonoBehaviour {

    bool playerIsHere;
    public FourWayGun eGunR;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            print("player is here");
            playerIsHere = true;
            eGunR.shooting = true;      
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            print("player has left");
            playerIsHere = false;
            eGunR.shooting = false;
        }
    }

}
