﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMoverLerp4way : MonoBehaviour {

    public GameObject p1, p2, p3, p4;
    //public GameObject Obs;
    public float speed;
    public bool move1, move2, move3, move4;
    float distance1, distance2, distance3, distance4;


    // Use this for initialization
    void Start()
    {
        move1 = false;
        move2 = false;
        move3 = false;
        move4 = false;
        transform.position = p1.transform.position;
    }

    void FixedUpdate()
    {
        float deltaPosition = speed * Time.deltaTime;


        distance1 = Vector2.Distance(transform.position, p1.transform.position);
        distance2 = Vector2.Distance(transform.position, p2.transform.position);
        distance3 = Vector2.Distance(transform.position, p3.transform.position);
        distance4 = Vector2.Distance(transform.position, p4.transform.position);


        if (distance1 < 0.4f)
        {
            move1 = true;
            move4 = false;
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
            transform.position = Vector2.Lerp(transform.position, p3.transform.position, deltaPosition);
        }

        if (distance3 < 0.42f)
        {
            move2 = false;
            move3 = true;
        }

        if (move3)
        {
            transform.position = Vector2.Lerp(transform.position, p4.transform.position, deltaPosition);
        }

        if (distance4 < 0.42f)
        {
            move3 = false;
            move4 = true;
        }

        if (move4)
        {
            transform.position = Vector2.Lerp(transform.position, p1.transform.position, deltaPosition);
        }

    }
}
