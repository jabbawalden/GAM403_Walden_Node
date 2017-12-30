using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DataSlots : MonoBehaviour {


    public void BeginNewGame_ONE()
    {
        if (GameDataStorage.gameData.game1 == false)
        {
            SceneManager.LoadScene("Main Menu", LoadSceneMode.Single);
            GameDataStorage.gameData.game1 = true;
            GameDataStorage.gameData.LoadOne();
        }

    }

    public void DeleteSlotOne()
    {
        GameDataStorage.gameData.DeleteSaveOne();
    }


    public void BeginNewGame_TWO()
    {
        if (GameDataStorage.gameData.game2 == false)
        {
            SceneManager.LoadScene("Main Menu", LoadSceneMode.Single);
            GameDataStorage.gameData.game2 = true;
            GameDataStorage.gameData.LoadTwo();
        }
           


    }

    public void DeleteSlotTwo()
    {
        GameDataStorage.gameData.DeleteSaveTwo();
    }

    public void BeginNewGame_THREE()
    {
        if (GameDataStorage.gameData.game3 == false)
        {
            SceneManager.LoadScene("Main Menu", LoadSceneMode.Single);
            GameDataStorage.gameData.game3 = true;
            GameDataStorage.gameData.LoadThree();
        }
       


    }

    public void DeleteSlotThree()
    {
        GameDataStorage.gameData.DeleteSaveThree();
    }

    /*
    public void BeginNewGame_ONE()
    {
               
         SceneManager.LoadScene("Main Menu", LoadSceneMode.Single);
         //GameDataStorage.gameData.game1 = true;
         GameDataStorage.gameData.LoadOne();   
        
    }

    public void DeleteSlotOne ()
    {
        GameDataStorage.gameData.DeleteSaveOne();
    }
 

    public void BeginNewGame_TWO()
    {
        SceneManager.LoadScene("Main Menu", LoadSceneMode.Single);
        //GameDataStorage.gameData.game2 = true;
        GameDataStorage.gameData.LoadTwo();
    
       
    }

    public void DeleteSlotTwo()
    {
        GameDataStorage.gameData.DeleteSaveTwo();
    }

    public void BeginNewGame_THREE()
    {
        SceneManager.LoadScene("Main Menu", LoadSceneMode.Single);
        //meDataStorage.gameData.game3 = true;
        GameDataStorage.gameData.LoadThree();

     
    }

    public void DeleteSlotThree()
    {
        GameDataStorage.gameData.DeleteSaveThree();
    }
    */
}
