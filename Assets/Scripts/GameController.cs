using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    public static GameController control;
    //sets to static - now accessible to all other scripts
    public int maxHealth = 3;
    public int techCollected = 0;
    public int totalPlayerSpeed = 10;
    public float totalFireRate = 0.4f;
    public int pProjSpeed = 30;
    public Text techShow;
    
   
    //public GameObject upgradePanel;
    //bool panelCheck = false;

    public bool completeLevel1 = false;
    public bool completeLevel2 = false;
    public bool completeLevel3 = false;
    public bool freeUpgrade = true;
    public float delayTimeCheck = 0.8f;

    //various values, bools and references

    public GameObject techHolder;
    //turn techHolder false in inspector so that canvas is not in the way when editting.

    public int bossFinalHealth; 

    void Awake()
    {
        
        if (control == null)
        {
            DontDestroyOnLoad(gameObject);
            control = this; //this becomes the one object referenced by this variable
        } else if (control != this)
        {
            Destroy(gameObject);
            //if already exists, destroy this - singleton design pattern i.e. there can
            //only be one of these. Very useful for holding persistent information about player stats
            //and game/level state (for one off events etc.)
        }
        

       
        
    }

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        //will persist from scene to scene
        techHolder.SetActive(true);
        //turn on when game starts
       

    }

    void OnGUI()
    {
        /*
        if (//healthbutton)
        {
            maxHealth += 1;
        }

       // GUI.Label(new Rect(10, 70, 100, 30), "techParts: " + techParts);
       */
    }

    
	
	void Update ()
    {
        techShow.text = "Tech Collected: " + techCollected;
        //sets on screen UI to show amount of tech

        /*
        if (panelCheck == false)
        {
            upgradePanel.SetActive(false);
        }

        if (panelCheck == true)
        {
            upgradePanel.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            panelCheck = !panelCheck;

        }
        */


    }

 

}
