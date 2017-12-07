using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossTrapEnabler : MonoBehaviour
{

    public GameObject invisibleTrap, barrenTile;
    public EnemyTrigger triggerBool;

    private void Start()
    {
        invisibleTrap.SetActive(false);
    }

     void Update ()
    {
        if (triggerBool.playerIsHere == true)
        {
            invisibleTrap.SetActive(true);
            barrenTile.SetActive(false);
        }
    }


}
