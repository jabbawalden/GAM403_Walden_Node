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
        else if (GameController.control.pProjSpeed == 35 && GameController.control.techCollected >= 50)
        {

            GameController.control.pProjSpeed = 40;
            GameController.control.techCollected -= 50;
            GameController.control.delayTimeCheck = 0.7f;
         

        }
        else if (GameController.control.pProjSpeed == 40 && GameController.control.techCollected >= 65)
        {

            GameController.control.pProjSpeed = 45;
            GameController.control.techCollected -= 65;
            GameController.control.delayTimeCheck = 0.65f;
   

        }
        else if (GameController.control.pProjSpeed == 45 && GameController.control.techCollected >= 80)
        {

            GameController.control.pProjSpeed = 50;
            GameController.control.techCollected -= 80;
            GameController.control.delayTimeCheck = 0.6f;
         
        }




    }

    public void Update()
    {

        if (GameController.control.pProjSpeed == 35)
        {
            bulletSpeedCost.text = "Cost: 50 Tech";
            bulletSpeedLVL.text = "LVL 2";
        }

        if (GameController.control.pProjSpeed == 40)
        {
            bulletSpeedCost.text = "Cost: 65 Tech";
            bulletSpeedLVL.text = "LVL 3";
        }

        if (GameController.control.pProjSpeed == 45)
        {
            bulletSpeedCost.text = "Cost: 80 Tech";
            bulletSpeedLVL.text = "LVL 4";
        }

        if (GameController.control.pProjSpeed == 50)
        {
            bulletSpeedCost.text = "Max Upgrades Reached";
            bulletSpeedLVL.text = "LVL 5";
        }
    }
}
