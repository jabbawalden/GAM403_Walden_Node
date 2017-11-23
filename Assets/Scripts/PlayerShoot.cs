using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

    public GameObject projectile;
    public GameObject playerCol;
    public Transform shotOrigin;
    public float fireRate;
	public float Damage;
	public LayerMask notToHit;
    float nextFire = 0;

	// Use this for initialization
	void Start () 
    {

        

    }
	

	// Update is called once per frame
	void Update ()
    {
        

        if (Input.GetKeyDown(KeyCode.Mouse0) && Time.time > nextFire)           
        {
            nextFire = Time.time + fireRate;
            GameObject pClone = Instantiate(projectile, shotOrigin.position, shotOrigin.rotation) as GameObject;
            Physics2D.IgnoreCollision(projectile.GetComponent<Collider2D>(), playerCol.GetComponent<Collider2D>());
            //GameObject type name Clone - gives us a reference to the new object made
            //allows us to define it's behaviour now that we have access to it
            //as GameObject - Instantiate projectile as a GameObject 
        }

        

    }

}


//Resource: https://unity3d.com/learn/tutorials/projects/space-shooter/shooting-shots?playlist=17147