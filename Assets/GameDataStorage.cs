using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class GameDataStorage : MonoBehaviour
{
    public static GameDataStorage gameData;


    public bool game1, game2, game3;
    
    //public bool delete1, delete2, delete3;

    public bool g1exists, g2exists, g3exists;
    public bool g1Start, g2Start, g3Start;


    void Awake()
    {
        if (gameData == null)
        {
            DontDestroyOnLoad(gameObject);
            gameData = this; 
        }
        else if (gameData != this)
        {
            Destroy(gameObject);
         
        }

        /*
        delete1 = false;
        delete2 = false;
        delete3 = false;
        */
        g1Start = false;
        g2Start = false;
        g3Start = false;

        //booleans to check when a game has begun. Initally set to flase until a level begins.
    }  

    void Update()
    {

        if (File.Exists(Application.persistentDataPath + "/PlayerGameOne.dat"))
        {
           
            g1exists = true;
         
        } else
        {
            g1exists = false;
         
        }

        if (File.Exists(Application.persistentDataPath + "/PlayerGameTwo.dat"))
        {

            g2exists = true;
           
        }
        else
        {
            g2exists = false;
            
        }

        if (File.Exists(Application.persistentDataPath + "/PlayerGameThree.dat"))
        {

            g3exists = true;
         
        }
        else
        {
            g3exists = false;
           
        }
        /*
        if (g1exists == false)
        {
            delete1 = true;
        }

        if (g2exists == false)
        {
            delete2 = true;
        }

        if (g3exists == false)
        {
            delete3 = true;
        }
        */
    }

    public void SaveOne ()
    {
        
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/PlayerGameOne.dat");
        PlayerData data = new PlayerData();

        data.maxHealth = GameController.control.maxHealth;
        data.techCollected = GameController.control.techCollected;
        data.totalPlayerSpeed = GameController.control.totalPlayerSpeed;
        data.totalFireRate = GameController.control.totalFireRate;
        data.pProjSpeed = GameController.control.pProjSpeed;

        data.completeLevel1 = GameController.control.completeLevel1;
        data.completeLevel2 = GameController.control.completeLevel2;
        data.completeLevel3 = GameController.control.completeLevel3;
        data.freeUpgrade = GameController.control.freeUpgrade;


        bf.Serialize(file, data);
        file.Close();
        
        game1 = false;
        g1Start = false; 
        //checks for when game has no longer started. if file is deleted during 1 play, we must know when to
        //reset stats to default
        /*
        delete1 = false;
        g1exists = true;
        */

    }

    public void SaveTwo()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/PlayerGameTwo.dat");
        PlayerData data = new PlayerData();

        data.maxHealth = GameController.control.maxHealth;
        data.techCollected = GameController.control.techCollected;
        data.totalPlayerSpeed = GameController.control.totalPlayerSpeed;
        data.totalFireRate = GameController.control.totalFireRate;
        data.pProjSpeed = GameController.control.pProjSpeed;

        data.completeLevel1 = GameController.control.completeLevel1;
        data.completeLevel2 = GameController.control.completeLevel2;
        data.completeLevel3 = GameController.control.completeLevel3;
        data.freeUpgrade = GameController.control.freeUpgrade;

        bf.Serialize(file, data);
        file.Close();

       
        game2 = false;
        g2Start = false;
        /*
         delete2 = false;
         g2exists = true;
         */
    }

    public void SaveThree()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/PlayerGameThree.dat");
        PlayerData data = new PlayerData();
  
        /*
        delete3 = false;
        g3exists = true;
        */
        data.maxHealth = GameController.control.maxHealth;
        data.techCollected = GameController.control.techCollected;
        data.totalPlayerSpeed = GameController.control.totalPlayerSpeed;
        data.totalFireRate = GameController.control.totalFireRate;
        data.pProjSpeed = GameController.control.pProjSpeed;

        data.completeLevel1 = GameController.control.completeLevel1;
        data.completeLevel2 = GameController.control.completeLevel2;
        data.completeLevel3 = GameController.control.completeLevel3;
        data.freeUpgrade = GameController.control.freeUpgrade;
        /*
        data.g3exists = g3exists;
        */


        bf.Serialize(file, data);
        file.Close();

        game3 = false;
        g3Start = false;



        //data.game3 = game3;
        // data.delete3 = delete3;


    }

    public void LoadOne()
    {
        if(File.Exists(Application.persistentDataPath + "/PlayerGameOne.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();;
            FileStream file = File.Open(Application.persistentDataPath + "/PlayerGameOne.dat", FileMode.Open);
            PlayerData data = (PlayerData)bf.Deserialize(file);
            

            GameController.control.maxHealth = data.maxHealth;
            GameController.control.techCollected = data.techCollected;
            GameController.control.totalPlayerSpeed = data.totalPlayerSpeed;
            GameController.control.totalFireRate = data.totalFireRate;
            GameController.control.pProjSpeed = data.pProjSpeed;

            GameController.control.completeLevel1 = data.completeLevel1;
            GameController.control.completeLevel2 = data.completeLevel2;
            GameController.control.completeLevel3 = data.completeLevel3;
            GameController.control.freeUpgrade = data.freeUpgrade;
            print("game1 loaded");
            file.Close();
        }
      
    }

    public void LoadTwo()
    {
        if (File.Exists(Application.persistentDataPath + "/PlayerGameTwo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter(); ;
            FileStream file = File.Open(Application.persistentDataPath + "/PlayerGameTwo.dat", FileMode.Open);
            PlayerData data = (PlayerData)bf.Deserialize(file);
            

            GameController.control.maxHealth = data.maxHealth;
            GameController.control.techCollected = data.techCollected;
            GameController.control.totalPlayerSpeed = data.totalPlayerSpeed;
            GameController.control.totalFireRate = data.totalFireRate;
            GameController.control.pProjSpeed = data.pProjSpeed;

            GameController.control.completeLevel1 = data.completeLevel1;
            GameController.control.completeLevel2 = data.completeLevel2;
            GameController.control.completeLevel3 = data.completeLevel3;
            GameController.control.freeUpgrade = data.freeUpgrade;
            print("game2 loaded");
            file.Close();
        }
    }

    public void LoadThree()
    {
        if (File.Exists(Application.persistentDataPath + "/PlayerGameThree.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter(); ;
            FileStream file = File.Open(Application.persistentDataPath + "/PlayerGameThree.dat", FileMode.Open);
            PlayerData data = (PlayerData)bf.Deserialize(file);
            

           // g3exists = data.g3exists;
            GameController.control.maxHealth = data.maxHealth;
            GameController.control.techCollected = data.techCollected;
            GameController.control.totalPlayerSpeed = data.totalPlayerSpeed;
            GameController.control.totalFireRate = data.totalFireRate;
            GameController.control.pProjSpeed = data.pProjSpeed;

            GameController.control.completeLevel1 = data.completeLevel1;
            GameController.control.completeLevel2 = data.completeLevel2;
            GameController.control.completeLevel3 = data.completeLevel3;
            GameController.control.freeUpgrade = data.freeUpgrade;
            print("game3 loaded");


            //game3 = data.game3;
            //delete3 = data.delete3;
            file.Close();

        }
    }

    public void DeleteSaveOne() 
    {
        if (File.Exists(Application.persistentDataPath + "/PlayerGameOne.dat"))
        {
            File.Delete(Application.persistentDataPath + "/PlayerGameOne.dat");
            //delete1 = true;
            //g1exists = false;
        } 

        
    }

   
    public void DeleteSaveTwo()
    {
        if (File.Exists(Application.persistentDataPath + "/PlayerGameTwo.dat"))
        {
            File.Delete(Application.persistentDataPath + "/PlayerGameTwo.dat");
           // delete2 = true;
            //g2exists = false;
        }
    }

    public void DeleteSaveThree()
    {
        if (File.Exists(Application.persistentDataPath + "/PlayerGameThree.dat"))
        {
            File.Delete(Application.persistentDataPath + "/PlayerGameThree.dat");
           //delete3 = true;
           //g3exists = false;
        }
    }
  
} 

[Serializable]
public class PlayerData
{
    public int maxHealth;
    public int techCollected;
    public int totalPlayerSpeed;
    public float totalFireRate;
    public int pProjSpeed;

    public bool completeLevel1;
    public bool completeLevel2;
    public bool completeLevel3;
    public bool freeUpgrade;

    public bool game1, game2, game3;
    public bool delete1, delete2, delete3;
    public bool g1exists, g2exists, g3exists;
}


