using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TechBox : MonoBehaviour {

    public GameObject techBox;
    public GameObject techText;
    public int techAmount; //so that we can set tech amount per box in inspector

    private void Start()
    {
        techText.SetActive(false);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {                     
            GameController.control.techCollected += techAmount;
            Destroy(techBox);
            techText.SetActive(true);
            
        }
        //if player makes contact, destroy item and add the set techAmount.
    }
}
