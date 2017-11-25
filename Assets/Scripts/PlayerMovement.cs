using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody2D rb; //rigidbody variable
    public BoxCollider2D bc; //box collider variable
    public float speed; //speed of movement float
	private Vector2 axisForce; //will hold axis horizontal and vertical
                               //Vectors hold directional values.
    public PlayerShoot pShoot;
    public int health = 3;

	// Use this for initialization
	void Update ()
    {
		PInput (); //calls Player Input Function into update (per frame)


    }

	//detects player input
	void PInput ()
	{
		//GetAxis calls the inbuilt Unity Axis for movement directions
		float H = Input.GetAxis("Horizontal");
		float V = Input.GetAxis("Vertical");

		//axisForce is equal to a vector2 with Horizontal and Vertical axis's on the Y and X
		axisForce = new Vector2 (H, V);

		PMovement (axisForce * speed); //Calls the Player Movement function
		/*
		 * Within the (), we have the Input.GetAxis Vector (axisForce) * speed of movement 
		 * adds speed to the directional input, within the PMovement function that holds the movement
		 * calculations for both moving and also not moving when no input is detected.
		*/

	}

	//for moving the player
	//this function holds a vector named pForce
	void PMovement (Vector2 pForce)
	{
		
		rb.velocity = Vector2.zero;
        //resets the velocity when player is not inputting

       // print(rb.velocity);

		rb.AddForce (pForce, ForceMode2D.Impulse);
		//adds force to pForce, with ForceMode2D.Impulse - changes the force mode to instant.

		//this function now has a force added to it?

	}

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            Debug.Log("Hit obstacle");
            FindObjectOfType<GameState>().EndGame();
            speed = 0;
        }

        if (collision.collider.CompareTag("EProj"))
        {
            if (health == 0)
            {
                speed = 0f;
                FindObjectOfType<GameState>().EndGame();
                pShoot.alive = false;
            }
            
        }
    }

  





}
