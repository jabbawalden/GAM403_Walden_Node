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
    public bool delete1, delete2, delete3;

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

        delete1 = false;
        delete2 = false;
        delete3 = false;

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
        delete1 = false;
        
 
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
        delete2 = false;
    }

    public void SaveThree()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/PlayerGameThree.dat");
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

        game3 = false;
        delete3 = false;
    }

    public void LoadOne()
    {
        if(File.Exists(Application.persistentDataPath + "/PlayerGameOne.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();;
            FileStream file = File.Open(Application.persistentDataPath + "/PlayerGameOne.dat", FileMode.Open);
            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();

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
        }
      
    }

    public void LoadTwo()
    {
        if (File.Exists(Application.persistentDataPath + "/PlayerGameTwo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter(); ;
            FileStream file = File.Open(Application.persistentDataPath + "/PlayerGameTwo.dat", FileMode.Open);
            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();

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
        }
    }

    public void LoadThree()
    {
        if (File.Exists(Application.persistentDataPath + "/PlayerGameThree.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter(); ;
            FileStream file = File.Open(Application.persistentDataPath + "/PlayerGameThree.dat", FileMode.Open);
            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();

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
        }
    }

    public void DeleteSaveOne() 
    {
        if (File.Exists(Application.persistentDataPath + "/PlayerGameOne.dat"))
        {
            File.Delete(Application.persistentDataPath + "/PlayerGameOne.dat");
            delete1 = true;
        }
    }

   
    public void DeleteSaveTwo()
    {
        if (File.Exists(Application.persistentDataPath + "/PlayerGameTwo.dat"))
        {
            File.Delete(Application.persistentDataPath + "/PlayerGameTwo.dat");
            delete2 = true;
        }
    }

    public void DeleteSaveThree()
    {
        if (File.Exists(Application.persistentDataPath + "/PlayerGameThree.dat"))
        {
            File.Delete(Application.persistentDataPath + "/PlayerGameThree.dat");
            delete3 = true;
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
}


