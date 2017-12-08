using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapActivation : MonoBehaviour {

    public GameObject trap;
    public EnemyTrigger trigger;
    public GameObject[] enemyArray;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (trigger.playerIsHere == true)
        {
            trap.SetActive(true);
        }

        if (enemyArray == null)
        {
            trap.SetActive(false);
        }

    }
}
