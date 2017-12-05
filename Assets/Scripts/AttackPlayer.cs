using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPlayer : MonoBehaviour {

    public EnemyTrigger targetTrigger;
    public Transform originalPosition;
    public Transform playerPosition;
    public float speed = 10;
    public Rigidbody2D rb;
    
	
	
	// Update is called once per frame
	void Update ()
    {
        float deltaPosition = speed * Time.deltaTime;
       

        if (targetTrigger.playerIsHere == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, playerPosition.position, deltaPosition);

        }
        else if (targetTrigger.playerIsHere == false)
        {
            transform.position = Vector2.MoveTowards(transform.position, originalPosition.position, deltaPosition);

        }


    }

    //same as the other Attack script, except this object moves directly to player position. If player touches it, they die.

   
}
