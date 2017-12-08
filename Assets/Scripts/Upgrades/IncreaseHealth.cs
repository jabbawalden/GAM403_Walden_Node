using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseHealth : MonoBehaviour {

	public void HealthIncrease ()
    {
        if (GameController.control.maxHealth >= 8)
        {
            GameController.control.maxHealth = 8;
        }
        else if (GameController.control.techCollected >= 20 && GameController.control.maxHealth <= 8)
        {
            GameController.control.maxHealth++;
            GameController.control.techCollected -= 20;

        }
        
    }
}
