using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable2 : MonoBehaviour {

    public GameObject collectableStone;
    public bool haveBeenCollected = false;
    public BoxCollider2D bc;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collectableStone);
            haveBeenCollected = true;
            bc.enabled = false;
            GameController.control.completeLevel2 = true;
        }
    }
}
