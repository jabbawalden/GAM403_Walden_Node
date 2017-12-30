using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGameMenu : MonoBehaviour {

    public void SaveGameData()
    {
        //upon button click
        SceneManager.LoadScene("SaveLoadSlots", LoadSceneMode.Single);

        if (GameDataStorage.gameData.game1)
        {      
            GameDataStorage.gameData.SaveOne();
            print("game1 saved");
            GameDataStorage.gameData.game1 = false;
        }


        if (GameDataStorage.gameData.game2)
        {
            GameDataStorage.gameData.game2 = false;
            GameDataStorage.gameData.SaveTwo();
            print("game2 saved");
        } 


        if (GameDataStorage.gameData.game3)
        {
            GameDataStorage.gameData.game3 = false;
            GameDataStorage.gameData.SaveThree();
            print("game3 saved");
        } 


    }

} 
