using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginLastLevel : MonoBehaviour {

    public void TolastLevel()
    {
        if (GameController.control.completeLevel3 == false)
        {
             
        }
        else if (GameController.control.completeLevel3 == true)
        {
            SceneManager.LoadScene("LevelFour_V1", LoadSceneMode.Single);

        }



    }
}
