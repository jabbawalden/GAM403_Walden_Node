using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalWin : MonoBehaviour {

    public EnemyTrigger winTrigger;
    public GameObject winMenu;

    private void Start()
    {
        winMenu.SetActive(false);
    }

    private void Update()
    {
        if (winTrigger.playerIsHere == true)
        {
            winMenu.SetActive(true);
        }
    }
}
