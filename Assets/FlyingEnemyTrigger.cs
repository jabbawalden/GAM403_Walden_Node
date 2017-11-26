using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEnemyTrigger : MonoBehaviour {

    public bool targetArrived = false;


    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "player")
        {
            targetArrived = true;
            Debug.Log("triggeredFollow");
        }

        
       
    }
}
