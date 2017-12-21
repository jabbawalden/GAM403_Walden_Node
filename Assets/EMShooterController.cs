using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EMShooterController : MonoBehaviour {

    public int emHealth = 4;

    private void Update()
    {
        if (emHealth == 0)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "PProj")

        {
            emHealth -= 1;
        }

   
        
    }
}
