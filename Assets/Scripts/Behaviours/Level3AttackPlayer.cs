using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3AttackPlayer : MonoBehaviour {

    public EnemyTrigger targetTrigger;
    public Transform originalPosition;
    public Transform playerPosition;
    public float speed = 10;
    public Rigidbody2D rb;
    public int distance;
    //varaibles for distance from player, rb, speed of movement, the player position
    //original position and trigger

    void Start()
    {
        //Vector2 distance = new Vector2(Random.Range(4, 8), Random.Range(4, 8));
        
        
    }

    // Update is called once per frame
    void Update()
    {
        float deltaPosition = speed * Time.deltaTime;
        //Time.deltaTime to help with framerates
        
        var targetPosition = (transform.position - playerPosition.position).normalized * distance + playerPosition.position;
        //finding the targetpositions direction at any one time.

        if (targetTrigger.playerIsHere == true) 
        {

            transform.position = Vector2.MoveTowards(transform.position, targetPosition, deltaPosition);
            //if true, move towards targetposition, but only at the set distance (works from any direction)

        }
        else if (targetTrigger.playerIsHere == false)
        {
            transform.position = Vector2.MoveTowards(transform.position, originalPosition.position, deltaPosition);
            //else, move towards original position if player leaves

        }


    }

    

}
