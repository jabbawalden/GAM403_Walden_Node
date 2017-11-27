using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherFuckingTrigger : MonoBehaviour {

    public bool reachedPointOne = false;

    public void OnTriggerEnter2D(Collider2D collision)
    {
    
        print("are you even alive?");

        if (collision.gameObject.CompareTag("Player"))
        {
            print("why are you not working dick head");
            reachedPointOne = true;
        }
    }
}
