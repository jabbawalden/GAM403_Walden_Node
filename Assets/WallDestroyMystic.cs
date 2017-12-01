using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDestroyMystic : MonoBehaviour {

    public GameObject mystical;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (mystical == null)
        {
            Destroy(gameObject);
        }

	}
}
