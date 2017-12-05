using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class tileAppear : MonoBehaviour {

    public GameObject gunDestructable;
    public GameObject groundAppear;
    public GameObject invisibleWall;
    //variables set

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (gunDestructable == null)
        {
            groundAppear.SetActive(true);
            invisibleWall.SetActive(false);
        }
        //remove collider and enable ground
	}
}
