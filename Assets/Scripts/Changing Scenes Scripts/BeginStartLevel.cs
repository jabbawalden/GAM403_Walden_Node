using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginStartLevel : MonoBehaviour {

    public void TeleportToStart()
    {
        SceneManager.LoadScene("WarpGate (tutorial)", LoadSceneMode.Single);
    }
}
