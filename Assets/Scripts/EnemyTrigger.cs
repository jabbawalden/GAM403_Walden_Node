using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger : MonoBehaviour {

    bool playerIsHere;
    public EnemyGunShoot eGun;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            print("player is here");
            playerIsHere = true;
            eGun.shooting = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            print("player has left");
            playerIsHere = false;
            eGun.shooting = false;
        }
    }
}
