using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EProjectileBehaviour : MonoBehaviour {

    public Rigidbody2D rb;
    public float speed;
    public GameObject projectile; 
    public GameObject projectileHolder;

    // Use this for initialization
    void Start ()
    {
       

    }
	

    void Update()
    {
        rb.AddForce(projectile.transform.up * speed * Time.deltaTime, ForceMode2D.Impulse);
        DestroyObjectDelayed();
    }

    void DestroyObjectDelayed()
    {

        Destroy(projectileHolder, 3);
    }
}
