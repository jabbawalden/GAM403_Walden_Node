using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EProjectileBehaviourThree : MonoBehaviour {

    public Rigidbody2D rb;
    public float speed;
    public GameObject projectile;
    public GameObject projectileHolder;
    private PlayerMovement playerHealth;

    void Start()
    {

        rb.velocity = new Vector3 (- projectile.transform.position.x * speed, 0, 0 );
        DestroyObjectDelayed();
        playerHealth = FindObjectOfType<PlayerMovement>();
        
    }

    void DestroyObjectDelayed()
    {

        Destroy(projectileHolder, 3);
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        {
            if (collision.gameObject.tag == "Player")
            {
                Destroy(gameObject);
                playerHealth.health = playerHealth.health - 1;
               
            }

            if (collision.gameObject.tag == "PProj")
            {
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }

            if (collision.gameObject.tag == "Environment" || collision.gameObject.tag == "Obstacle")
            {

                Destroy(gameObject);
            }
        }
    }
}
