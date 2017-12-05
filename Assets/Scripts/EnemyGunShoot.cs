using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGunShoot : MonoBehaviour {

    public GameObject enemyProjectile;
    public Transform eSOrigin;
    public float fireRate;
    public float damage;
    float nextFire = 0;
    public EnemyTrigger trigger;
    public bool shooting = false;
    //variables setting firerate, position bullet instansiates from, trigger for when to fire (or not fire)
    //bool to choose when firing is active and not active

    void Update()
    {
        if (shooting)
        {
            EnemyShoot();
        }
        //call EnemyShoot function
        
        if (trigger.playerIsHere == true)
        {
            shooting = true;
        }

        if (trigger.playerIsHere == false)
        {
            shooting = false;
        }
        //if trigger bool true, set to relevant value
    }

    void EnemyShoot()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            GameObject pClone = Instantiate(enemyProjectile, eSOrigin.position, eSOrigin.rotation) as GameObject;
            
        }
        //enemy instantiates projectile at a particular rate from enemy shoot origin position
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
