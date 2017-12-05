using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable2 : MonoBehaviour {

    public GameObject collectableStone;
    public bool haveBeenCollected2 = false;
    public BoxCollider2D bc;
    public GameObject comepletedLevel;
    

    // Use this for initialization
    void Start()
    {
        comepletedLevel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       if (haveBeenCollected2 == true)
       {
            comepletedLevel.SetActive(true);
       }

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collectableStone);
            haveBeenCollected2 = true;
            bc.enabled = false;
            GameController.control.completeLevel2 = true;
        }
    }
}
