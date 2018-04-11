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
    public GameObject heal1, heal2;

    //variables for boss move to player

    public BossController bossShields;

    private void Start()
    {
        heal1.SetActive(false);
        heal2.SetActive(false);

        distance = 12;

        bossHealth = GameController.control.bossFinalHealth;
    } 

    void Update()
    {
        

        if (bossHealth == 0)
        {
            Destroy(gameObject);
        }

        if (bossShields.shieldsDown == true)
        {
            AttackPlayerMove();
        } else
        {
            return;
        }

        if (bossHealth == 110)
        {
            bossShields.SecondShield = true;
            heal1.SetActive(true);
            distance = 4;
        }

        if (bossHealth == 70)
        {
            
            distance = 11;
        }

        if (bossHealth == 50)
        {
            heal2.SetActive(true);
            distance = 8;
            
        }

        if (bossHealth == 20)
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
