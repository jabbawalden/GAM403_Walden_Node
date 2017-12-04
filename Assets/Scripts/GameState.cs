using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour {

    
    public bool gameHasEnded = false;
    public float restartDelay;
    public bool weHaveWon = false;
    public Collectable collectable;
    public Collectable2 collectable2;


    void Update()
    {
        if (collectable.haveBeenCollected == true)
        {
            weHaveWon = true; 

        }

        if (collectable2.haveBeenCollected2 == true)
        {
            weHaveWon = true;

        }
        //if (collectable2.haveBeenCollected == true)
        //{
        //    weHaveWon2 = true;

            //}

        if (weHaveWon == true)
        {
            if (Input.GetKeyDown("space"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                print("pressingSpace");
            }
        }

        if (collectable2.haveBeenCollected2 == true)
        {
            if (Input.GetKeyDown("space"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                print("pressingSpace");
            }
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
