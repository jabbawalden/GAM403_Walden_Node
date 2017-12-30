using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSlotUpdater : MonoBehaviour {

    
    public Text slot1Text, slot2Text, slot3Text;

    void Update()
    {
        SlotOne();

        SlotTwo();

        SlotThree();

    }

    public void SlotOne ()
    {
        
        if (GameDataStorage.gameData.g1exists)
        {
            slot1Text.text = "Load Game One";
        }
        else if (GameDataStorage.gameData.g1exists == false)
        {
            slot1Text.text = "Begin New Game";
        }
        
    }

    public void SlotTwo()
    {
        if (GameDataStorage.gameData.g2exists)
        {
            slot2Text.text = "Load Game Two";
        }
        else if (GameDataStorage.gameData.g2exists == false)
        {
            slot2Text.text = "Begin New Game";
        }
    }

    public void SlotThree()
    {
        if (GameDataStorage.gameData.g3exists)
        {
            slot3Text.text = "Load Game Three";
        }
        else if (GameDataStorage.gameData.g3exists == false)
        {
            slot3Text.text = "Begin New Game";
        }
    }
    
}
