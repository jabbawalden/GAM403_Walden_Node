using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueExploringLevel : MonoBehaviour {

    public Collectable completedLevel;
     

	public void ContinueLevelExploration()
    {
        completedLevel.haveBeenCollected = false;
        completedLevel.goToNextLevel.SetActive(false);

    }

    //if button clicked, remove panel.

}
