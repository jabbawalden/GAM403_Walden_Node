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
    public bool alive = true;

	// Use this for initialization
	void Start () 
    {
        fireRate = GameController.control.totalFireRate;

    }
	

	// Update is called once per frame
	void Update ()
    {
        if (alive)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0) && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                GameObject pClone = Instantiate(projectile, shotOrigin.position, shotOrigin.rotation) as GameObject;
                //GameObject type name Clone - gives us a reference to the new object made
                //allows us to define it's behaviour now that we have access to it
                //as GameObject - Instantiate projectile as a GameObject 
            }

        }

       

        

    }

}


//Resource: https://unity3d.com/learn/tutorials/projects/space-shooter/shooting-shots?playlist=17147