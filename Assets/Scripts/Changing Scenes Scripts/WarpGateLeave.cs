using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpGateLeave : MonoBehaviour {

    public GameObject leaveMenu;

    void Start()
    {
        leaveMenu.SetActive(false);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            leaveMenu.SetActive(true); 
        }
    }
}
