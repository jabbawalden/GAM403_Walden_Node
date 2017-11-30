﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EProjBehaviourToPlayer : MonoBehaviour {

    public Rigidbody2D rb;
    public float speed;
    public GameObject projectile;
    public GameObject projectileHolder;
    private PlayerMovement playerHealth;
    




    void Start()
    {
        var playerPos = FindObjectOfType<PlayerMovement>().playerPosition;

        Vector2 target = new Vector2(playerPos.position.x - transform.position.x, playerPos.position.y - transform.position.y);

        target.Normalize();
        target *= speed;

        rb.velocity = target;

        /*
        Vector3 wp = Camera.main.ScreenToWorldPoint(new Vector3(playerPos.position.x, playerPos.position.y, 0f));
        //wp equals mouse position on x and y on screen space 
        Vector3 target = new Vector3(wp.x, wp.y, transform.position.z);
        //moving from screen space to world space 

        Vector3 direction = target - transform.position; //direction is equal to target - our position 
                                                         //so that it is only calculating the direction 

        direction.Normalize(); //fixes the speed 
        direction *= speed; //direction = direction * speed 
                            //rb.velocity = Vector2.MoveTowards (transform.position, target, speed); 
        rb.velocity = direction;
        //sends velocity in direciton 
        //rb.velocity = -projectile.transform.up * speed;

    */

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
