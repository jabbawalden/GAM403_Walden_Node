using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateMessage : MonoBehaviour {

    public GameObject line;


	// Use this for initialization
	void Start ()
    {
        

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            line.SetActive(true);
            Debug.Log("player line activate");
        }
    }


}
