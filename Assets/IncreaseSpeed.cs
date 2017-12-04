using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseSpeed : MonoBehaviour
{ 

    public void SpeedIncrease ()
    {
        if (GameController.control.techCollected >= 15)
        {
            GameController.control.totalPlayerSpeed++;
            GameController.control.techCollected -= 15;
        }
      
    } 

}
