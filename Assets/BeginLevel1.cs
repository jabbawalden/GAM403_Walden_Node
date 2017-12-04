using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginLevel1 : MonoBehaviour {

    public void ToLevel1()
    {
        SceneManager.LoadScene("LevelOne_V1", LoadSceneMode.Single);
        print("we have moved to next scene");
    }


}
