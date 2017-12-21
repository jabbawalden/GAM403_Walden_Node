using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EProjectileBehaviourTwo : MonoBehaviour {

    public Rigidbody2D rb;
    public float speed;
    public GameObject projectile, projExplosion;
    public GameObject projectileHolder;
    private PlayerMovement playerHealth;
    public BoxCollider2D bc;
    bool destroy;

    void Start() 
    {

        rb.velocity = projectile.transform.up * speed;
        DestroyObjectDelayed();
        playerHealth = FindObjectOfType<PlayerMovement>();
        projExplosion.SetActive(false);
    }

    void DestroyObjectDelayed()
    {

        Destroy(projectile, 3);
    }

    void FixedUpdate()
    {
        if (projectile == null)
        {
            rb.velocity = Vector2.zero;
            bc.enabled = false;
            projExplosion.SetActive(true);
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
                playerHealth.health = playerHealth.health - 1;
                speed = 0;
                projExplosion.SetActive(true);
                Destroy(gameObject, 1);
                bc.enabled = false;
            }

            if (collision.gameObject.tag == "PProj")
            {
                Destroy(collision.gameObject);
                Destroy(projectile);
                speed = 0;
                projExplosion.SetActive(true);
                Destroy(gameObject, 1);
                bc.enabled = false;
            }

            if (collision.gameObject.tag == "Environment" || collision.gameObject.tag == "Obstacle")
            {

                Destroy(projectile);
                speed = 0;
                projExplosion.SetActive(true);
                Destroy(gameObject, 1);
                bc.enabled = false;
            }
        }
    }
}
