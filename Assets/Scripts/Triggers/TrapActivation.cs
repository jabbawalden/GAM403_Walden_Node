using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapActivation : MonoBehaviour {

    public GameObject trap;
    public EnemyTrigger trigger;
    public GameObject[] enemyArray;

	// Use this for initialization
	void Start ()
    {
        trap.SetActive(false);
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (trigger.playerIsHere == true)
        {
            trap.SetActive(true);
        }

       
        
       if (enemyArray[0] == null && enemyArray[1] == null && enemyArray[2] == null)
       {
                trap.SetActive(false);
                return;
       }
        
    
        

    }
}
