using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OMovement : MonoBehaviour {



    public Transform P1;
    public Transform P2;
    bool moveRight;
    bool moveLeft;
    public float speed = 4;
    //variables to check speed, position of P1 and P2 + bools to set when to move left and right

    private void Start()
    {
        transform.position = P1.transform.position;      
        moveLeft = false;
        //at start, do this.
    }

    void Update()
    {
        float deltaPosition = speed * Time.deltaTime;        
        //to do via time instead of framerate as this varies

        if (transform.position == P1.transform.position)
        {
            moveLeft = false;
        }
           

        if (transform.position == P2.transform.position)
        {
            moveLeft = true;
        }
        //if at this position, set bool to true or false (only needed one bool)
         

        if (moveLeft)
        {
            transform.position = Vector2.MoveTowards(transform.position, P1.position, deltaPosition);

        } else 
        {
            transform.position = Vector2.MoveTowards(transform.position, P2.position, deltaPosition);
       
        }
        //if moveLeft, moveTowards opposite position, otherwise move back to the first one.

        /* if (transform.position == P1.transform.position) 
         { 
             transform.position = Vector2.MoveTowards(transform.position, P2.position, eSpeed);
         } else 
         if (transform.position == P2.transform.position)
         {
             transform.position = Vector2.MoveTowards(transform.position, P1.position, eSpeed);
         }

        if (moveLeft == false)
        {
            transform.position = Vector2.MoveTowards(transform.position, P2.position, eSpeed);
            
        } else if (moveLeft == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, P1.position, eSpeed);
        }

      */

    }



    /*
     *       
      if (moveLeft == true)
       transform.position = Vector2.MoveTowards(transform.position, P1.position, eSpeed);

      if (transform.position == P1.position)
        {
            print("at position 1");
        }

     * if (transform.position == P2.transform.position)
        {
            transform.position = Vector2.MoveTowards(transform.position, P1.position, eSpeed);
        }
	// Use this for initialization
	void Start ()
    {
        Vector2 Pos1 = new Vector2(P1.position.x, P1.position.y);
        Vector2 Pos2 = new Vector2(P2.position.x, P2.position.y);
        transform.position = Pos1;

	}
	
	// Update is called once per frame
	void Update ()
    {
        

		if (transform.position == P1.transform.position)
        {
            Vector2.MoveTowards (transform.position, P2.transform.position, Speed * Time.deltaTime);
        }

	}
    */
}
