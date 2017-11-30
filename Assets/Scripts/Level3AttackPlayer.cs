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

    void Start()
    {
        //Vector2 distance = new Vector2(Random.Range(4, 8), Random.Range(4, 8));
        
        
    }

    // Update is called once per frame
    void Update()
    {
        float deltaPosition = speed * Time.deltaTime;

        
        var targetPosition = (transform.position - playerPosition.position).normalized * distance + playerPosition.position;

        if (targetTrigger.playerIsHere == true)
        {

            transform.position = Vector2.MoveTowards(transform.position, targetPosition, deltaPosition);

        }
        else if (targetTrigger.playerIsHere == false)
        {
            transform.position = Vector2.MoveTowards(transform.position, originalPosition.position, deltaPosition);

        }


    }

    /*
      if (targetTrigger.playerIsHere == true)
     {
         transform.position = Vector2.MoveTowards(transform.position, playerPosition.position, deltaPosition);

     }
     else if (targetTrigger.playerIsHere == false)
     {
         transform.position = Vector2.MoveTowards(transform.position, originalPosition.position, deltaPosition);

     }
     
    distanceX = player.position.x - transform.position.x;
    distanceZ = player.position.z - transform.position.z;
    transform.position = Vector3.Lerp(new Vector3(transform.position.x, transform.position.y, transform.position.z), new Vector3(transform.position.x + distanceX, transform.position.y, transform.position.z + distanceZ), Time.deltaTime);
    */

}
