using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneOperatorSelect : MonoBehaviour {

   

    public void ToMainMenu ()
    {
        SceneManager.LoadScene("Main Menu", LoadSceneMode.Single);
        print("we have moved to next scene");
    }

    public void ToUpgradeScreen()
    {
        SceneManager.LoadScene("Upgrade System", LoadSceneMode.Single);
        print("we have moved to next scene");
    }

    public void ToLevel1()
    {
        SceneManager.LoadScene("LevelOne_V1", LoadSceneMode.Single);
        print("we have moved to next scene");
    }

    public void ToLevel2()
    {
        SceneManager.LoadScene("LevelTwo_V1", LoadSceneMode.Single);
        print("we have moved to next scene");
    }

    public void ToLevel3()
    {
        SceneManager.LoadScene("LevelThree_V1", LoadSceneMode.Single);
        print("we have moved to next scene");
    }
}
