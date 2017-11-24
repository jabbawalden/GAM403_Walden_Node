using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourWayGun : MonoBehaviour {

    public GameObject eProj1;
    public GameObject eProj2;
    public GameObject eProj3;
    public GameObject eProj4;
    public Transform eSOrigin;
    public Transform eSOrigin2;
    public Transform eSOrigin3;
    public Transform eSOrigin4;
    public float fireRate;
    public float damage; 
    float nextFire = 0;
    public EnemyGunTrigger trigger; 
    public bool shooting = false;

    void Update()
    { 
        if (shooting)
        {
            EnemyShoot();
        }


    }

    void EnemyShoot()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            GameObject pClone = Instantiate(eProj1, eSOrigin.position, eSOrigin.rotation) as GameObject;
            GameObject pClone2 = Instantiate(eProj2, eSOrigin2.position, eSOrigin2.rotation) as GameObject;
            GameObject pClone3 = Instantiate(eProj3, eSOrigin3.position, eSOrigin3.rotation) as GameObject;
            GameObject pClone4 = Instantiate(eProj4, eSOrigin4.position, eSOrigin4.rotation) as GameObject;
        }
    }


    /*
        public GameObject projectile;
        public Transform shotOrigin;
        public float fireRate;
        public float Damage;
        public LayerMask notToHit;
        float nextFire = 0;

        // Use this for initialization
        void Start()
        {



        }


        // Update is called once per frame
        void Update()
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

        */
}


