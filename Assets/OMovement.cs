using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OMovement : MonoBehaviour {



    public Transform P1;
    public Transform P2;
    bool moveRight;
    bool moveLeft;
    float speed = 2;

    private void Start()
    {
        transform.position = P1.transform.position;
        moveRight = true;
        moveLeft = false;
    }

    void Update()
    {
        float eSpeed = speed * Time.deltaTime;

      if (moveRight == true)
       transform.position = Vector2.MoveTowards(transform.position, P2.position, eSpeed);
        
      if (moveLeft == true)
       transform.position = Vector2.MoveTowards(transform.position, P1.position, eSpeed);

      if (transform.position == P1.position)
        {
            print("at position 1");
        }

     

    }

    /*
     * 
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
