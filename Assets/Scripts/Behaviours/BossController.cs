using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour {

    public GameObject carrier1, carrier2, carrier3, carrier4, carrier5, carrier6;
    public GameObject shield1, shield2, shield3; 
    public GameObject bossMaster;
    public GameObject gameWon, finalFinish;
    public GameObject shoot1, shoot2, shoot3;
    public GameObject pillars, attackplayerFinals, attackplayerFinals2;
    public GameObject rock1, rock2;

    
    public bool SecondShield = false;

    public bool shieldsDown = false;
    //variables to check for nulls/conditions of the objects and execute code when
    //those conditions are reached.





    // Use this for initialization


    void Start ()
    {
        gameWon.SetActive(false);
        finalFinish.SetActive(false);
        attackplayerFinals.SetActive(false);
        attackplayerFinals2.SetActive(false);

        shield3.SetActive(false);
        SecondShield = false;
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

        
        if (SecondShield)
        {
            shieldsDown = false;
            shield3.SetActive(true);
            Destroy(rock1);
            Destroy(rock2);
        }

        if (carrier5 == null && carrier6 == null)
        {
            Destroy(shield3);
            shieldsDown = true;
            SecondShield = false;
            attackplayerFinals2.SetActive(true);
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
