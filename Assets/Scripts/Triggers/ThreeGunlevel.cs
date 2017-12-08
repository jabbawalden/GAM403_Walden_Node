using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreeGunlevel : MonoBehaviour {
    public GameObject tiles;
    public GameObject invisibleWall;
    public GameObject gun1;
    public GameObject gun2;
    public GameObject gun3;
    bool levelwon = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (gun1 == null && gun2 == null && gun3 == null)
        {
            invisibleWall.SetActive(false);
            tiles.SetActive(true);
          
        }
		
	}
}
