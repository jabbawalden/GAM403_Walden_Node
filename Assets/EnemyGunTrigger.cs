using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGunTrigger : MonoBehaviour {


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            print("player is here");
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            print("player has left"); 
        }
    }

}
