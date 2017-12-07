using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour {

    public GameObject carrier1, carrier2, carrier3, carrier4;
    public GameObject shield1, shield2;
    public GameObject bossMaster;
    public GameObject gameWon, finalFinish;
    public GameObject shoot1, shoot2, shoot3;
    public GameObject pillars, attackplayerFinals;

    public bool shieldsDown = false;
    //variables to check for nulls/conditions of the objects and execute code when
    //those conditions are reached.





    // Use this for initialization


    void Start ()
    {
        gameWon.SetActive(false);
        finalFinish.SetActive(false);
        attackplayerFinals.SetActive(false);
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (carrier1 == null && carrier2 == null)
        {
            Destroy(shield1);
        }

        if (carrier3 == null && carrier4 == null)
        {
            Destroy(shield2);
        }

        if (shield1 == null && shield2 == null )
        {
            shieldsDown = true;
        }

        if (shieldsDown == true)
        {
            pillars.SetActive(false);
            attackplayerFinals.SetActive(true);
        }

        if (bossMaster == null)
        {
            gameWon.SetActive(true);
            finalFinish.SetActive(true);
            shoot1.SetActive(false);
            shoot2.SetActive(false);
            shoot3.SetActive(false);

        }

    }



}
