using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileV2Appear : MonoBehaviour {

    public GameObject[] enemyArray;
    public GameObject groundAppear;
    public GameObject invisibleWall;
    //variables set

    // Use this for initialization
    void Start()
    {
        groundAppear.SetActive(false);
        invisibleWall.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
    

        if (enemyArray[0] == null && enemyArray[1] == null && enemyArray[2] == null)
        {
            groundAppear.SetActive(true);
            invisibleWall.SetActive(false);
            return;
        }


    }
}
