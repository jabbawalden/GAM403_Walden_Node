using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCol : MonoBehaviour {

    public GameObject playerCol;
    public GameObject pProjectileCol; 
        


	// Use this for initialization
	void Start ()
    {

        

    }
	
	// Update is called once per frame
	void Update ()
    {
        Physics2D.IgnoreCollision(pProjectileCol.GetComponent<Collider2D>(), playerCol.GetComponent<Collider2D>());
    }
}
