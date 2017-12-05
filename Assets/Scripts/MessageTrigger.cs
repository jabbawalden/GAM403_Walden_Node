using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageTrigger : MonoBehaviour {

    public GameObject line;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (line == null)
        {
            return;
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            line.SetActive(true);
            Debug.Log("Player here now");
        }
        //if player enters trigger, set message animation


        //if (collision.CompareTag("Player") && wall == null)
        //{
        //    line.SetActive(false);
        //    Debug.Log("Player here now");
        //}

    }

}
