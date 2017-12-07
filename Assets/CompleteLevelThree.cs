using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteLevelThree : MonoBehaviour {

    public Collectable checkCompletion;

    public void Update()
    {
        if (checkCompletion.haveBeenCollected == true)
        {
            GameController.control.completeLevel3 = true;
        }
    }
}
