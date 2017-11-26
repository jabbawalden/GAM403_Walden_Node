using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour {

    public Rigidbody2D rb;
    public float speed;
    public GameObject projectile;
    public GameObject projectileHolder;
    

	void Start ()
    {
        
		//Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); 


		var mousePosition = Input.mousePosition; 
    
	
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

        
        

	}

    void Update()
    {
        DestroyObjectDelayed();
    }

    void DestroyObjectDelayed ()
    {

        Destroy(projectileHolder, 0.8f);
    }
    /* 
     private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Indestructable"))
        {
            projectile.SetActive(false);

        }

    }
    */

    void OnCollisionEnter2D(Collision2D collision)
    {
        {
            if (collision.gameObject.tag == "Enemy")
            {
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }

            if (collision.gameObject.tag == "EProj")
            {
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }

            if (collision.gameObject.tag == "Environment" || collision.gameObject.tag == "Obstacle")
            {               
                Destroy(gameObject);
            }

        }
    }

}
