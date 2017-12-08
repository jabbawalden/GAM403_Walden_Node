using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginLevel3 : MonoBehaviour {

    public void ToLevel3()
    {
        if (GameController.control.completeLevel2 == false)
        {

        }
        else if (GameController.control.completeLevel2 == true)
        {
            SceneManager.LoadScene("LevelThree_V1", LoadSceneMode.Single);

        } 

      
       
    }
}
