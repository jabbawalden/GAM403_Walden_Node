using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour {

	public GameObject player;
	public Vector3 offset;
    //offest (set to -20 on z) and player position
	
	// Update is called once per frame
	void Update () 
	{
		transform.position = player.transform.position + offset;
        //camera follows player and camera set a distance to take in 
        if (player == null)
        {
            return;
        }
        
	}
}
