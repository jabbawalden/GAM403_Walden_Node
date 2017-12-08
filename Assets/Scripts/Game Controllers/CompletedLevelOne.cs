using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompletedLevelOne : MonoBehaviour {

    public Collectable checkCompletion;

    public void Update()
    {
        if (checkCompletion.haveBeenCollected == true)
        {
            GameController.control.completeLevel1 = true;
        }
    }
}
