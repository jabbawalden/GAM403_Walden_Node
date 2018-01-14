using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSlotUpdater : MonoBehaviour {

    
    public Text slot1Text, slot2Text, slot3Text;
    public Button b1, b2, b3;

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
            b1.image.color = Color.magenta;
        }
        else if (GameDataStorage.gameData.g1exists == false)
        {
            slot1Text.text = "Begin New Game";
            b1.image.color = Color.white;
        }
        
    }

    public void SlotTwo()
    {
        if (GameDataStorage.gameData.g2exists)
        {
            slot2Text.text = "Load Game Two";
            b2.image.color = Color.magenta;
        }
        else if (GameDataStorage.gameData.g2exists == false)
        {
            slot2Text.text = "Begin New Game";
            b2.image.color = Color.white;
        }
    }
     
    public void SlotThree()
    {
        if (GameDataStorage.gameData.g3exists)
        {
            slot3Text.text = "Load Game Three";
            b3.image.color = Color.magenta;
        }
        else if (GameDataStorage.gameData.g3exists == false)
        {
            slot3Text.text = "Begin New Game";
            b3.image.color = Color.white;
        }
    }
    
}
