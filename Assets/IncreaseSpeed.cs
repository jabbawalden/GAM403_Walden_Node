using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseSpeed : MonoBehaviour
{ 

    public void SpeedIncrease ()
    {
        if (GameController.control.techCollected >= 15)
        {
            if (GameController.control.totalPlayerSpeed <= 16)
            {

                GameController.control.totalPlayerSpeed++;
                GameController.control.techCollected -= 15;

            }
            else if (GameController.control.totalPlayerSpeed >= 17)
            {
                GameController.control.totalPlayerSpeed = 17;
                
            }
            
        }
      
    } 

}
