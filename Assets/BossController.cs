using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour {

    public GameObject carrier1, carrier2, carrier3, carrier4;
    public GameObject shield1, shield2;
    public GameObject bossMaster;
    public GameObject gameWon;

    //variables to check for nulls/conditions of the objects and execute code when
    //those conditions are reached.

	// Use this for initialization
	void Start ()
    {
        gameWon.SetActive(false);	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (carrier1 == null && carrier2 == null)
        {
            shield1.SetActive(false);
        }

        if (carrier3 == null && carrier4 == null)
        {
            shield2.SetActive(false);
        }

        if (bossMaster == null)
        {
            gameWon.SetActive(true);

        }

    }
}
