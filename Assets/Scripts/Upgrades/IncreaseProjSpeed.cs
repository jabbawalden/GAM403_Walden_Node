using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseProjSpeed : MonoBehaviour {

    public void ProjSpeedIncrease()
    {
        if (GameController.control.pProjSpeed >= 50)
        {
            GameController.control.pProjSpeed = 50;
            GameController.control.delayTimeCheck = 0.6f;

        }
        else if (GameController.control.pProjSpeed <= 45 && GameController.control.techCollected >= 50)
        {

            GameController.control.pProjSpeed += 5;
            GameController.control.techCollected -= 50;
            GameController.control.delayTimeCheck -= 0.05f;

        }




    }
}
