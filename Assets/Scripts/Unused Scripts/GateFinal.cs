using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateFinal : MonoBehaviour {

    public PlayerMovement playerMovement;
    public GameObject walltext;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (playerMovement.stoneHalf1 == true && playerMovement.stoneHalf2 == true)
        {
            Destroy(gameObject);
            Destroy(walltext);
        }

    }

   
}
