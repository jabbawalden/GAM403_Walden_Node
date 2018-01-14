using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMoverLerp2way : MonoBehaviour {

    public GameObject p1, p2;
    //public GameObject Obs;
    public float speed;
    public bool move1, move2;
    float distance1, distance2;


    // Use this for initialization
    void Start()
    {
        move1 = false;
        move2 = false;
        transform.position = p1.transform.position;
    }

    void FixedUpdate()
    {
        float deltaPosition = speed * Time.deltaTime;

        distance1 = Vector2.Distance(transform.position, p1.transform.position);
        distance2 = Vector2.Distance(transform.position, p2.transform.position);
 

        if (distance1 < 0.4f)
        {
            move1 = true;
            move2 = false;
        }

        if (move1)
        {
            transform.position = Vector2.Lerp(transform.position, p2.transform.position, deltaPosition);
        }

        if (distance2 < 0.4f)
        {
            move1 = false;
            move2 = true;
        }

        if (move2)
        {
            transform.position = Vector2.Lerp(transform.position, p1.transform.position, deltaPosition);
        }

  


    }
}
