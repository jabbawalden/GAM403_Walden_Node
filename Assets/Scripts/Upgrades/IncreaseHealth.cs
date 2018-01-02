using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncreaseHealth : MonoBehaviour {

    public Text healthCost, healthLevel;

	public void HealthIncrease ()
    {
        if (GameController.control.maxHealth >= 8)
        {
            GameController.control.maxHealth = 8;
        }
        else if (GameController.control.techCollected >= 20 && GameController.control.maxHealth == 3)
        {
            GameController.control.maxHealth++;
            GameController.control.techCollected -= 20;

        }
        else if (GameController.control.techCollected >= 25 && GameController.control.maxHealth == 4)
        {
            GameController.control.maxHealth++;
            GameController.control.techCollected -= 25;

        }
        else if (GameController.control.techCollected >= 35 && GameController.control.maxHealth == 5)
        {
            GameController.control.maxHealth++;
            GameController.control.techCollected -= 35;

        }
        else if (GameController.control.techCollected >= 50 && GameController.control.maxHealth == 6)
        {
            GameController.control.maxHealth++;
            GameController.control.techCollected -= 50;

        }
        else if (GameController.control.techCollected >= 75 && GameController.control.maxHealth == 7)
        {
            GameController.control.maxHealth++;
            GameController.control.techCollected -= 75;

        }

    }

    public void Update()
    {
        if (GameController.control.maxHealth == 4)
        {
            healthCost.text = "Cost: 25 Tech";
            healthLevel.text = "LVL 4";
        }

        if (GameController.control.maxHealth == 5)
        {
            healthCost.text = "Cost: 35 Tech";
            healthLevel.text = "LVL 5";
        }

        if (GameController.control.maxHealth == 6)
        {
            healthCost.text = "Cost: 50 Tech";
            healthLevel.text = "LVL 6";
        }

        if (GameController.control.maxHealth == 7)
        {
            healthCost.text = "Cost: 75 Tech";
            healthLevel.text = "LVL 7";
        }


        if (GameController.control.maxHealth == 8)
        {
            healthCost.text = "Max Upgrade Reached";
            healthLevel.text = "LVL 8";
        }
    }
}
