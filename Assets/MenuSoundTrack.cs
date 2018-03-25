using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSoundTrack : MonoBehaviour {

    public static MenuSoundTrack menuSoundTrack;


    private void Awake()
    {
        if (menuSoundTrack == null)
        {
            DontDestroyOnLoad(gameObject);
            menuSoundTrack = this; //this becomes the one object referenced by this variable
        }
        else if (menuSoundTrack != this)
        {
            Destroy(gameObject);
            //if already exists, destroy this - singleton design pattern i.e. there can
            //only be one of these. Very useful for holding persistent information about player stats
            //and game/level state (for one off events etc.)
        }


    }

    // Use this for initialization
    void Start ()
    {
       
       
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("LevelOne_V1") ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByName("LevelTwo_V1") ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByName("LevelThree_V1") ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByName("LevelFour_V1") ||
            SceneManager.GetActiveScene() == SceneManager.GetSceneByName("WarpGate (tutorial)")
           )
        {
            Destroy(gameObject);
        }
    }

}

