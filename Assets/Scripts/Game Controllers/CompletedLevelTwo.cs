using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompletedLevelTwo : MonoBehaviour {


    public Collectable checkCompletion;

    public void Update()
    {
        if (checkCompletion.haveBeenCollected == true)
        {
            GameController.control.completeLevel2 = true;
        }
    }
}
