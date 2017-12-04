﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour {

    
    public bool gameHasEnded = false;
    public float restartDelay;
    public bool weHaveWon = false;
    public Collectable collectable;
    

    void Update()
    {
        if (collectable.haveBeenCollected == true)
        {
            weHaveWon = true; 

        }

        if (collectable == null)
        {
            return;
        }

        if (Input.GetKeyDown("space") && collectable.haveBeenCollected == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            
        }


    }

    /*public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);       
           
        }


     

    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    */
    
}
