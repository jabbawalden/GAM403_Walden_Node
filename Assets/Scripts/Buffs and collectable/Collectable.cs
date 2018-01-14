using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour {

    public GameObject collectableStone;
    public bool haveBeenCollected = false;
    public BoxCollider2D bc;
    public GameObject goToNextLevel;
    public bool nextLevelActivated; 

	// Use this for initialization
	void Start ()
    { 
        goToNextLevel.SetActive(false);
        nextLevelActivated = false;
        //sets to false
    }
	
	// Update is called once per frame
	void Update ()
    {
		//if (haveBeenCollected == true)
  //      {
  //          goToNextLevel.SetActive(true);
  //      }
  

	}

    public void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.gameObject.CompareTag("Player"))
       {
           //Destroy(collectableStone);
           haveBeenCollected = true; 
           //bc.enabled = false; 
           //GameController.control.completeLevel1 = true;
           goToNextLevel.SetActive(true);
           nextLevelActivated = true;
           

       }
        
       //checks bool to be true and sets panel active
    }

 

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            goToNextLevel.SetActive(false);

        }
        //automatically dissapears when player leaves

    }

}
