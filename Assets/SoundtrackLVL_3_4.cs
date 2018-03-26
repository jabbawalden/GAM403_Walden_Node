using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundtrackLVL_3_4 : MonoBehaviour {

    public static SoundtrackLVL_3_4 soundtrackLVL_3_4;

    // Use this for initialization
    void Start()
    {
        if (soundtrackLVL_3_4 == null)
        {
            DontDestroyOnLoad(gameObject);
            soundtrackLVL_3_4 = this; //this becomes the one object referenced by this variable
        }
        else if (soundtrackLVL_3_4 != this)
        {
            Destroy(gameObject);
            //if already exists, destroy this - singleton design pattern i.e. there can
            //only be one of these. Very useful for holding persistent information about player stats
            //and game/level state (for one off events etc.)
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("SaveLoadSlots") ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByName("LevelOne_V1") ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByName("LevelTwo_V1") ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Main Menu") ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Upgrade System") ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByName("WarpGate (tutorial)")
           )
        {
            Destroy(gameObject);
        }
    }
}
