using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMain : MonoBehaviour {

    public int bossHealth;

    public Transform playerPosition;
    public float speed = 29;
    //public Rigidbody2D rb;
    public int distance;
    public EnemyTrigger targetTrigger;

    //variables for boss move to player

    public BossController bossShields;

    private void Start()
    {
        bossHealth = GameController.control.bossFinalHealth;
        distance = 6;
    } 

    void Update()
    {
        bossHealth = GameController.control.bossFinalHealth;

        if (bossHealth == 0)
        {
            Destroy(gameObject);
        }

        if (bossShields.shieldsDown == true)
        {
            AttackPlayerMove();
        }

        if (bossHealth == 80)
        {
           
            distance = 7;
        }

        if (bossHealth == 50)
        {
          
            distance = 2;
        }

        if (bossHealth == 30)
        {
       
            distance = 4;
        }

        if (bossHealth == 10)
        {
           
            distance = 1;
        }
    }

    void AttackPlayerMove()
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
    }

}
