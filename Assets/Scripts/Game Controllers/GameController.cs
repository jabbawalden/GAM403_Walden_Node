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
       bossFinalHealth = 100;
  

    }

    void Update()

    {
        if (GameDataStorage.gameData.game1 || GameDataStorage.gameData.game2 || GameDataStorage.gameData.game3)
        {
            techHolder.SetActive(true);
        }
        else 
        {
            techHolder.SetActive(false);
        }
 
    }


    void FixedUpdate ()
    {
        techShow.text = "Tech Collected: " + techCollected;

        if (GameDataStorage.gameData.game1 == true && GameDataStorage.gameData.delete1 == true)
        {
            maxHealth = 3; 
            techCollected = 0;
            totalPlayerSpeed = 10;
            totalFireRate = 0.4f;
            pProjSpeed = 30;
            freeUpgrade = true;
    }

        if (GameDataStorage.gameData.game2 == true && GameDataStorage.gameData.delete2 == true)
        {
            maxHealth = 3;
            techCollected = 0;
            totalPlayerSpeed = 10;
            totalFireRate = 0.4f;
            pProjSpeed = 30;
            freeUpgrade = true;
        }

        if (GameDataStorage.gameData.game3 == true && GameDataStorage.gameData.delete3 == true)
        {
            maxHealth = 3;
            techCollected = 0;
            totalPlayerSpeed = 10;
            totalFireRate = 0.4f;
            pProjSpeed = 30;
            freeUpgrade = true;
        }

        
    }

 

}
