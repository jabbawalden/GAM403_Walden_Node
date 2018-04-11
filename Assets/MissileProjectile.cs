using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileProjectile : MonoBehaviour {

    public Rigidbody2D rb;
    public float speed;
    public GameObject projectile; /*projExplosion*/
    public GameObject projectileHolder;
    private PlayerMovement playerHealth;
    public BoxCollider2D bc;
    bool destroy;
    public float rotSpeed;


    void Start()
    {
    
        //projExplosion.SetActive(false);
    }

    void Update()
    {
        MissileFollow();

    }

    void MissileFollow ()
    {
        transform.Rotate(Vector3.forward * rotSpeed);

        var playerPos = FindObjectOfType<PlayerMovement>().playerPosition;

        Vector2 target = new Vector2(playerPos.position.x - transform.position.x, playerPos.position.y - transform.position.y);

        target.Normalize();
        target *= speed;

        rb.velocity = target;

        DestroyObjectDelayed();
        playerHealth = FindObjectOfType<PlayerMovement>();
    }

    void DestroyObjectDelayed()
    {

        Destroy(projectile, 7);
    }

    void FixedUpdate()
    {
        if (projectile == null)
        {
            rb.velocity = Vector2.zero;
            bc.enabled = false;
            //projExplosion.SetActive(true);
            destroy = true;

            if (destroy)
            {
                Destroy(gameObject, 1);
            }

        }
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        {
            if (collision.gameObject.tag == "Player")
            {
                Destroy(projectile);
                playerHealth.health -= 1;
                speed = 0;
                //projExplosion.SetActive(true);
                Destroy(gameObject, 3);
                bc.enabled = false;
            }

            if (collision.gameObject.tag == "PProj")
            {
                //Destroy(collision.gameObject);
                Destroy(projectile);
                speed = 0;
                //projExplosion.SetActive(true);
                Destroy(gameObject, 3);
                bc.enabled = false;
            }

            if (collision.gameObject.tag == "Environment" || collision.gameObject.tag == "Obstacle")
            {

                Destroy(projectile);
                speed = 0;
               // projExplosion.SetActive(true);
                Destroy(gameObject, 3);
                bc.enabled = false;
            }
        }
    }
}
