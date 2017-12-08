using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TechBox : MonoBehaviour {

    public GameObject techBox;
    public Collider2D colliderCheck;
    public int techAmount; //so that we can set tech amount per box in inspector

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {                     
            GameController.control.techCollected += techAmount;
            Destroy(techBox);
            Destroy(colliderCheck);
        }
        //if player makes contact, destroy item and add the set techAmount.
    }
}
