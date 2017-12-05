using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody2D rb; //rigidbody variable
    public BoxCollider2D bc; //box collider variable
    public float speed; //speed of movement float
	private Vector2 axisForce; //will hold axis horizontal and vertical
                               //Vectors hold directional values.
    public PlayerShoot pShoot;
    public int health = 3;
    public GameObject youLose;
    bool dead = false;
    //public GameState gameManager;
    //public GameObject youWinUI;

    public GameObject[] healthHearts;
    //public GameObject hEqualsOne;
    //public GameObject hEqualsTwo;
    //public GameObject hEqualsThree;
    public Transform playerPosition;
    //int healthIncrease;

    public bool stoneHalf1 = false;
    public bool stoneHalf2 = false;
    public bool techlost = false;
  

    void Start()
    {      
        //gameManager = FindObjectOfType<GameState>();
        health = GameController.control.maxHealth;
        speed = GameController.control.totalPlayerSpeed;
        
    }

    // Use this for initialization
    void Update ()
    {

        


        PInput (); //calls Player Input Function into update (per frame)

        if (dead == true)
        {
            if (techlost == false)
            {
                techlost = true;                              
                Invoke("DeductTechpoints", 0.2f);
                                
            }
           

            if (Input.GetKey(KeyCode.Space))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);              
            }
        }

        //if (gameManager.weHaveWon == true)
        //{
        //    speed = 0;
        //    pShoot.alive = false;
        //    youWinUI.SetActive(true);
        //}

        /*
        if (health == 2)
        {
            //hEqualsThree.SetActive(false);

        }

        if (health == 1)
        {
            //hEqualsTwo.SetActive(false);

        }

        if (health == 0)
        {
            //hEqualsOne.SetActive(false);

        }
        */


        for(int i = 0; i < healthHearts.Length; i++)
        {

            //if (health == i)
            //{
            //    healthHearts[i].SetActive(true);
            //}

            if (i > health - 1)
            {
                healthHearts[i].SetActive(false);
            }
            else
            {
                healthHearts[i].SetActive(true);
            }


        }

        /*if player upgrades, health = healthIncrease (increased in upgrade code)
         * Start Function
         * 
         * 
         */
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

    public void DeductTechpoints ()
    {

        if (GameController.control.techCollected >= 5)
        {
            GameController.control.techCollected -= 5;
        } else if (GameController.control.techCollected <= 5)
        {
            GameController.control.techCollected = 0;
        }

        //when player dies, this function is called. Lose 5 tech upon each death, 
        //otherwise if less than 5, equal to zero so that we don't go into negatives

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            Debug.Log("Hit obstacle");            
            speed = 0;
            dead = true;
            youLose.SetActive(true);
            pShoot.alive = false;
        }

        //if hits obstacle, dies.

        if (collision.collider.CompareTag("EProj"))
        {
            if (health == 0)
            {
                speed = 0f;
                youLose.SetActive(true);
                pShoot.alive = false;
                dead = true;               
                                          
            }
            
        }
        //if hit by eproj and health = 0, dies.

        if (collision.collider.CompareTag("Enemy"))
        {
            speed = 0f;
            youLose.SetActive(true);
            pShoot.alive = false;
            dead = true;
            bc.enabled = false;
            health = 0;
        }
        //if hits enemy, dies

        if (collision.collider.CompareTag("StoneHalf1"))
        {
            stoneHalf1 = true;
        }
        if (collision.collider.CompareTag("StoneHalf2"))
        {
            stoneHalf2 = true;
        }

        //above two check for stone collection in third level.
        //if both are collected, remove the blockade set at the middle of the level
    }


    

}
