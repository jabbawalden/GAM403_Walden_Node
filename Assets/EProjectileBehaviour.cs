using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EProjectileBehaviour : MonoBehaviour {

    public Rigidbody2D rb;
    public float speed;
    public GameObject projectile; 
    public GameObject projectileHolder;
    public Transform eSTarget;
    

    // Use this for initialization
    void Start ()
    {
        speed = speed * Time.deltaTime;
        


    }
	

    void Update()
    {
    
        rb.AddForce(projectile.transform.up * speed, ForceMode2D.Impulse);
        DestroyObjectDelayed();
    }

    void DestroyObjectDelayed()
    {

        Destroy(projectileHolder, 3);
    }

    
    void OnCollisionEnter2D(Collision2D collision)
    {
        {
            if (collision.gameObject.tag == "Player")
            {
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }

            if (collision.gameObject.tag == "PProj")
            {
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }

        }
    }




    /*
 * var mousePosition = Input.mousePosition; 


		

	
		Vector3 wp = Camera.main.ScreenToWorldPoint (new Vector3(mousePosition.x, mousePosition.y, 0f)); 
			//wp equals mouse position on x and y on screen space 
	 	Vector3 target = new Vector3 (wp.x, wp.y, transform.position.z); 
			//moving from screen space to world space 

		Vector3 direction = target - transform.position; //direction is equal to target - our position 
			//so that it is only calculating the direction 

		direction.Normalize (); //fixes the speed 
		direction *= speed; //direction = direction * speed 
		//rb.velocity = Vector2.MoveTowards (transform.position, target, speed); 
		rb.velocity = direction;
		//sends velocity in direciton 

    */
}




