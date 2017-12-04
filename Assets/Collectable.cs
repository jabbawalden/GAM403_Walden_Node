using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour {

    public GameObject collectableStone;
    public bool haveBeenCollected = false;
    public BoxCollider2D bc;
    public GameObject goToNextLevel;
    

	// Use this for initialization
	void Start ()
    {
        goToNextLevel.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {
		if (haveBeenCollected == true)
        {
            goToNextLevel.SetActive(true);
        }

	}

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collectableStone);
            haveBeenCollected = true;
            bc.enabled = false;
            GameController.control.completeLevel1 = true;
        }
    }
}
