using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginLevel2 : MonoBehaviour {

    

    public void ToLevel2()
        
    {
        if (GameController.control.completeLevel1 == false)
        {

        } else if (GameController.control.completeLevel1 == true)
        {
            SceneManager.LoadScene("LevelTwo_V1", LoadSceneMode.Single);
            print("we have moved to next scene");
        }
        
    }

}
