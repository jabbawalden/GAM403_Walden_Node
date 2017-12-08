using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportToLevelOne : MonoBehaviour {

	public void TeleportToLVL1()
    {
        SceneManager.LoadScene("LevelOne_V1", LoadSceneMode.Single);
    }
}
