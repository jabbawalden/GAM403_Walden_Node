using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseFireRate : MonoBehaviour {

	public void FireRateIncrease ()
    {
        if (GameController.control.totalFireRate <= 0.1f)
        {
            GameController.control.totalFireRate = 0.1f;


        }
        else if (GameController.control.techCollected >= 45 && GameController.control.totalFireRate >= 0.2f)
        {

            GameController.control.totalFireRate -= 0.1f;
            GameController.control.techCollected -= 45;
      
        }
     



    }

 
}
