using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TechBox : MonoBehaviour {

    public GameObject techBox;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {                     
            GameController.control.techCollected += 3;
            Destroy(techBox);          
        }
    }
}
