using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundtrackLVL_1_2 : MonoBehaviour {

    public static SoundtrackLVL_1_2 soundtrackLVL_1_2; 

    // Use this for initialization
    void Start ()
    {
        if (soundtrackLVL_1_2 == null)
        {
            DontDestroyOnLoad(gameObject);
            soundtrackLVL_1_2 = this; //this becomes the one object referenced by this variable
        }
        else if (soundtrackLVL_1_2 != this)
        {
            Destroy(gameObject);
            //if already exists, destroy this - singleton design pattern i.e. there can
            //only be one of these. Very useful for holding persistent information about player stats
            //and game/level state (for one off events etc.)
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("SaveLoadSlots") ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByName("LevelThree_V1") ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByName("LevelFour_V1") ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Main Menu") ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Upgrade System")
           )
        {
            Destroy(gameObject);
        }
    }
}
