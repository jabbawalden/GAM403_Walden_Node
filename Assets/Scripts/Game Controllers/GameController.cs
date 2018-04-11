using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

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
        }
        else if (control != this)
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
        bossFinalHealth = 150;

    

        
    }

    void Update()
    {
        techShow.text = "Tech Collected: " + techCollected;

        if (GameDataStorage.gameData.g1exists == false && GameDataStorage.gameData.game1 && GameDataStorage.gameData.g1Start == false)
        {
            maxHealth = 3;
            techCollected = 0;
            totalPlayerSpeed = 10;
            totalFireRate = 0.4f;
            pProjSpeed = 30;
            freeUpgrade = true;
            GameDataStorage.gameData.g1Start = true;
        } 
      

        if (GameDataStorage.gameData.g2exists == false && GameDataStorage.gameData.game2 && GameDataStorage.gameData.g2Start == false)
        {
            maxHealth = 3;
            techCollected = 0;
            totalPlayerSpeed = 10;
            totalFireRate = 0.4f;
            pProjSpeed = 30;
            freeUpgrade = true;
            GameDataStorage.gameData.g2Start = true;

        }
        

        if (GameDataStorage.gameData.g3exists == false && GameDataStorage.gameData.game3 && GameDataStorage.gameData.g3Start == false)
        {
            maxHealth = 3;
            techCollected = 0;
            totalPlayerSpeed = 10;
            totalFireRate = 0.4f;
            pProjSpeed = 30;
            freeUpgrade = true;
            GameDataStorage.gameData.g3Start = true;
        }
       
        //Logic of above code:
        //if there is no game saved, and we have entered the level, and game start check was previously false
        //Set stats to default + set game start to true, so that code no longer updates when player begins playing.


        if (GameDataStorage.gameData.game1 || GameDataStorage.gameData.game2 || GameDataStorage.gameData.game3)
        {
            techHolder.SetActive(true);
        }
        else
        {
            techHolder.SetActive(false);
        }

    }
}

        
 



   
    

