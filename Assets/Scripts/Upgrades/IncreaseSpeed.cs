﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncreaseSpeed : MonoBehaviour
{
    public Text speedCost, speedLVL;

    public void SpeedIncrease ()
    {
        if (GameController.control.techCollected >= 15 && GameController.control.totalPlayerSpeed == 10)
        {          
                GameController.control.totalPlayerSpeed++;
                GameController.control.techCollected -= 15;
        }
        else 
        if (GameController.control.techCollected >= 20 && GameController.control.totalPlayerSpeed == 11)
        {
                GameController.control.totalPlayerSpeed++;
                GameController.control.techCollected -= 20;
        }
        else
        if (GameController.control.techCollected >= 25 && GameController.control.totalPlayerSpeed == 12)
        {
                GameController.control.totalPlayerSpeed++;
                GameController.control.techCollected -= 25;
        }
        else
        if (GameController.control.techCollected >= 30 && GameController.control.totalPlayerSpeed == 13)
        {
                GameController.control.totalPlayerSpeed++;
                GameController.control.techCollected -= 30;
        }
        else
        if (GameController.control.techCollected >= 35 && GameController.control.totalPlayerSpeed == 14)
        {
                GameController.control.totalPlayerSpeed++;
                GameController.control.techCollected -= 35;
        }
        else
        if (GameController.control.techCollected >= 40 && GameController.control.totalPlayerSpeed == 15)
        {
                GameController.control.totalPlayerSpeed++;
                GameController.control.techCollected -= 40;
        }
        else
        if (GameController.control.techCollected >= 50 && GameController.control.totalPlayerSpeed == 16)
        {
                GameController.control.totalPlayerSpeed++;
                GameController.control.techCollected -= 50;
        }
        else
        if (GameController.control.techCollected >= 50 && GameController.control.totalPlayerSpeed == 17)
        {
                GameController.control.totalPlayerSpeed = 17;

        }
      
    }

    public void Update()
    {
        if (GameController.control.totalPlayerSpeed == 11)
        {
            speedCost.text = "Cost: 20 Tech";
            speedLVL.text = "LVL 2";
        }

        if (GameController.control.totalPlayerSpeed == 12)
        {
            speedCost.text = "Cost: 25 Tech";
            speedLVL.text = "LVL 3";
        }

        if (GameController.control.totalPlayerSpeed == 13)
        {
            speedCost.text = "Cost: 30 Tech";
            speedLVL.text = "LVL 4";
        }

        if (GameController.control.totalPlayerSpeed == 14)
        {
            speedCost.text = "Cost: 35 Tech";
            speedLVL.text = "LVL 5";
        }

        if (GameController.control.totalPlayerSpeed == 15)
        {
            speedCost.text = "Cost: 40 Tech";
            speedLVL.text = "LVL 6";
        }

        if (GameController.control.totalPlayerSpeed == 16)
        {
            speedCost.text = "Cost: 50 Tech";
            speedLVL.text = "LVL 7";
        }

        if (GameController.control.totalPlayerSpeed == 17)
        {
            speedCost.text = "Max Upgrades Reached";
            speedLVL.text = "LVL 8";
        }
    }

}
