using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncreaseFireRate : MonoBehaviour {
    public Text fireRateCost, fireRateLVL;

	public void FireRateIncrease ()
    {
      
        if (GameController.control.techCollected >= 25 && GameController.control.totalFireRate == 0.4f)
        {

            GameController.control.totalFireRate = 0.35f;
            GameController.control.techCollected -= 25;


        }
        else if (GameController.control.techCollected >= 40 && GameController.control.totalFireRate == 0.35f)
        {

            GameController.control.totalFireRate = 0.3f;
            GameController.control.techCollected -= 40;


        }
        else if (GameController.control.techCollected >= 50 && GameController.control.totalFireRate == 0.3f)
        {

            GameController.control.totalFireRate = 0.25f;
            GameController.control.techCollected -= 50;


        }
        else if (GameController.control.techCollected >= 65 && GameController.control.totalFireRate == 0.25f)
        {

            GameController.control.totalFireRate = 0.2f;
            GameController.control.techCollected -= 65;


        }
        else if (GameController.control.techCollected >= 80 && GameController.control.totalFireRate == 0.2f)
        {

            GameController.control.totalFireRate = 0.15f;
            GameController.control.techCollected -= 80;
     

        }
        else if (GameController.control.techCollected >= 100 && GameController.control.totalFireRate == 0.15f)
        {

            GameController.control.totalFireRate = 0.1f;
            GameController.control.techCollected -= 100;
       

        }
        else if (GameController.control.techCollected >= 125 && GameController.control.totalFireRate == 0.1f)
        {

            GameController.control.totalFireRate = 0.05f;
            GameController.control.techCollected -= 125;


        }
        else if (GameController.control.totalFireRate == 0.05f)
        {
            GameController.control.totalFireRate = 0.05f;
   

        }



    }

    public void Update()
    {
        
        if (GameController.control.totalFireRate == 0.4f)
        {
            fireRateCost.text = "Cost: 30 Tech";
            fireRateLVL.text = "LVL 1";
        }
    
        
        if (GameController.control.totalFireRate == 0.35f)
        {
            fireRateCost.text = "Cost: 40 Tech";
            fireRateLVL.text = "LVL 2";
        }
        
        if (GameController.control.totalFireRate == 0.3f)
        {
            fireRateCost.text = "Cost: 50 Tech";
            fireRateLVL.text = "LVL 3";
        }
      
        if (GameController.control.totalFireRate == 0.25f)
        {
            fireRateCost.text = "Cost: 65 Tech";
            fireRateLVL.text = "LVL 4";
        }
        
        if (GameController.control.totalFireRate == 0.2f)
        {
            fireRateCost.text = "Cost: 80 Tech";
            fireRateLVL.text = "LVL 5";
        }
      
        if (GameController.control.totalFireRate == 0.15f)
        {
            fireRateCost.text = "Cost: 100 Tech";
            fireRateLVL.text = "LVL 6";
        }
      
        if (GameController.control.totalFireRate == 0.1f)
        {
            fireRateCost.text = "Cost: 125 Tech";
            fireRateLVL.text = "LVL 7";
        }
    
        if (GameController.control.totalFireRate == 0.05f)
        {
            fireRateCost.text = "Max Upgrades Reached";
            fireRateLVL.text = "LVL 8";
        }
      
    }


}
