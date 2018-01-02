using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeAppear : MonoBehaviour {

    public GameObject fE1, fE2, fE3, fE4, fE5, fE6;
    public GameObject treeBunch;

    void Start()
    {
        treeBunch.SetActive(true);
    }

    // Update is called once per frame
    void Update ()
    {
		if (fE1 == null &&
            fE2 == null &&
            fE3 == null &&
            fE4 == null &&
            fE5 == null &&
            fE6 == null)
        {
            treeBunch.SetActive(false);
        }

	}
}
