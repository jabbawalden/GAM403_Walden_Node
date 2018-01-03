using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCheckTrigger : MonoBehaviour
{

    public GameObject invisibleWall, tiles;
    public GameObject e1, e2, e3, e4, e5, e6, e7;
    

    private void Start()
    {
      
        //invisibleWall.SetActive(true);
        //tiles.SetActive(false);

    }


    void Update ()
    {
        if (e1 == null && e2 == null && e3 == null && e4 == null && e5 == null && e6 == null && e7 == null)
        {
            invisibleWall.SetActive(false);
            tiles.SetActive(true);

        } else
        {
          
            invisibleWall.SetActive(true);
            tiles.SetActive(false);
        }
    }
    


   

}

   
