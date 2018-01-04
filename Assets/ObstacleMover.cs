using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMover : MonoBehaviour {

    public GameObject p1, p2, p3, p4;
    //public GameObject Obs;
    public float speed;
    public bool move1, move2, move3, move4;

 

	// Use this for initialization
	void Start ()
    {
        move1 = false;
        move2 = false;
        move3 = false;
        move4 = false;
        transform.position = p1.transform.position;
    }

	void FixedUpdate ()
    { 
        float deltaPosition = speed * Time.deltaTime;

        if (transform.position == p1.transform.position)
        {
            move1 = true;
            move4 = false;
        }

        if (move1)
        {
            transform.position = Vector2.MoveTowards(transform.position, p2.transform.position, deltaPosition);
        }

        if (transform.position == p2.transform.position)
        {
            move1 = false;
            move2 = true;
        }

        if (move2)
        {
            transform.position = Vector2.MoveTowards(transform.position, p3.transform.position, deltaPosition);
        }

        if (transform.position == p3.transform.position)
        {
            move2 = false;
            move3 = true;
        }

        if (move3)
        {
            transform.position = Vector2.MoveTowards(transform.position, p4.transform.position, deltaPosition);
        }

        if (transform.position == p4.transform.position)
        {
            move3 = false;
            move4 = true;
        }


        if (move4)
        {
            transform.position = Vector2.MoveTowards(transform.position, p1.transform.position, deltaPosition);
        }

    }
}
