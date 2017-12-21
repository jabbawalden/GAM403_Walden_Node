using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseFireRate : MonoBehaviour {

	public void FireRateIncrease ()
    {
        if (GameController.control.totalFireRate <= 0.05f)
        {
            GameController.control.totalFireRate = 0.05f;


        }
        else if (GameController.control.techCollected >= 35 && GameController.control.totalFireRate >= 0.05f)
        {

            GameController.control.totalFireRate -= 0.05f;
            GameController.control.techCollected -= 35;
      
        }
     



    }

 
}
