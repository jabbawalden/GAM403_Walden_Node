using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncreaseProjSpeed : MonoBehaviour {

    public Text bulletSpeedCost, bulletSpeedLVL;

    public void ProjSpeedIncrease()
    {
        if (GameController.control.pProjSpeed == 50)
        {
            GameController.control.pProjSpeed = 50;
            GameController.control.delayTimeCheck = 0.6f;
          

        }
        else if (GameController.control.pProjSpeed == 30 && GameController.control.techCollected >= 40)
        {

            GameController.control.pProjSpeed = 35;
            GameController.control.techCollected -= 40;
            GameController.control.delayTimeCheck = 0.75f;
    

        }
        else if (GameController.control.pProjSpeed == 35 && GameController.control.techCollected >= 55)
        {

            GameController.control.pProjSpeed = 40;
            GameController.control.techCollected -= 55;
            GameController.control.delayTimeCheck = 0.7f;
         

        }
        else if (GameController.control.pProjSpeed == 40 && GameController.control.techCollected >= 85)
        {

            GameController.control.pProjSpeed = 45;
            GameController.control.techCollected -= 85;
            GameController.control.delayTimeCheck = 0.65f;
   

        }
        else if (GameController.control.pProjSpeed == 45 && GameController.control.techCollected >= 100)
        {

            GameController.control.pProjSpeed = 50;
            GameController.control.techCollected -= 100;
            GameController.control.delayTimeCheck = 0.6f;
         
        }




    }

    public void Update()
    {

        if (GameController.control.pProjSpeed == 35)
        {
            bulletSpeedCost.text = "Cost: 55 Tech";
            bulletSpeedLVL.text = "LVL 2";
        }

        if (GameController.control.pProjSpeed == 40)
        {
            bulletSpeedCost.text = "Cost: 85 Tech";
            bulletSpeedLVL.text = "LVL 3";
        }

        if (GameController.control.pProjSpeed == 45)
        {
            bulletSpeedCost.text = "Cost: 100 Tech";
            bulletSpeedLVL.text = "LVL 4";
        }

        if (GameController.control.pProjSpeed == 50)
        {
            bulletSpeedCost.text = "Max Upgrades Reached";
            bulletSpeedLVL.text = "LVL 5";
        }
    }
}
