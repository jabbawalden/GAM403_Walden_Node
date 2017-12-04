using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToUpgradeScene : MonoBehaviour {


	public void ToUpgradeMenu ()
    {
        SceneManager.LoadScene("Upgrade System", LoadSceneMode.Single);
    }

}
