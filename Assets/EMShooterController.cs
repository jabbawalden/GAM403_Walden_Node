using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EMShooterController : MonoBehaviour {

    public int emHealth = 4;
   bool kill;

    private void Start()
    {
        kill = false;
    }
    void FixedUpdate()
    {
        if (kill)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "PProj")
        {
            if (!kill)
            {
                emHealth -= 1;
            }

            if (emHealth <= 0)
            {
                kill = true;
            }
        } 

   
        
    }
}
