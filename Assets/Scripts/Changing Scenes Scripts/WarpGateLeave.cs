using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpGateLeave : MonoBehaviour {

    public GameObject leaveMenu;
    public bool weAreLeaving;
    public PlayerMovement player;

    void Start()
    {
        leaveMenu.SetActive(false);
        weAreLeaving = false;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            leaveMenu.SetActive(true);
            weAreLeaving = true;
            player.speed = 0;
        }
    }

    public void Update()
    {
        //if (weAreLeaving)
        //{
        //    player.speed = 0;
        //    player.pShoot.alive = false;
        //}
        //else
        //{
        //    player.speed = GameController.control.totalPlayerSpeed;
        //    player.pShoot.alive = true;
        //}
    }
}
