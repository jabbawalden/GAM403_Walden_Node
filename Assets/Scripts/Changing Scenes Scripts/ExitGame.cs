using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour {

    bool gameQuit = false;

	public void ExitTheGame ()
    {
        if (GameDataStorage.gameData.game1)
        {
            GameDataStorage.gameData.SaveOne();
            gameQuit = true;

            if (gameQuit)
            {
                Application.Quit();
            }

        }

        if (GameDataStorage.gameData.game2)
        {
            GameDataStorage.gameData.SaveTwo();
            gameQuit = true;

            if (gameQuit)
            {
                Application.Quit();
            }

        }

        if (GameDataStorage.gameData.game3)
        {
            GameDataStorage.gameData.SaveThree();
            gameQuit = true;

            if (gameQuit)
            {
                Application.Quit();
            }

        }

        if (GameDataStorage.gameData.game1 == false || 
            GameDataStorage.gameData.game2 == false || 
            GameDataStorage.gameData.game3 == false)
        {
            Application.Quit();
        }


    }
}
