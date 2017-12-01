using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStoneCollected : MonoBehaviour {

    public GameObject mystical;
    public GameObject text;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (mystical == null)
        {
            text.SetActive(true);
        }
		
	}
}
