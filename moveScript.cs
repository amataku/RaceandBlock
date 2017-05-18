using UnityEngine;
using System.Collections;

public class moveScript : MonoBehaviour {
    public int level = 1;
    public int speed = 0;
    float movePower = 0.2f;
    bool jumppingFlug = true;
    Rigidbody rb;

	
	void Start () {

        rb = GetComponent<Rigidbody>();
	
	}
	

	void FixedUpdate () {
        if (Input.GetKey("up"))
        {
            Accel();
        }
        if (Input.GetKey("right"))
        {
            Right();
        }
        if (Input.GetKey("left"))
        {
            Left();
        }
        if (Input.GetKey("down"))
        {
            Down();
        }
        if (Input.GetKeyDown("space"))
        {
            if (jumppingFlug == true)
            {
                //Jump();
            }
        }

        if (level == 1 && speed > 75) { speed = 75; }
        if (level == 2 && speed > 100) { speed = 100; }
        if (level == 3 && speed > 125) { speed =125; }
        if (level == 4 && speed > 150) { speed = 150; }
        if (level == 5 && speed > 175) { speed = 175; }


        speed -= 2;

        if (speed < 0)
        {
            speed = 0;
        }
	
	}

    void Accel()
    {
        speed += 3;
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, speed);
        
    }

    void Right()
    {
        if (transform.position.x <= 5f)
        {
            Vector3 temp = new Vector3(transform.position.x + movePower, transform.position.y, transform.position.z);
            transform.position = temp;
        }
    }

    public void Left()
    {
        if (transform.position.x >= -5f)
        {
            Vector3 temp = new Vector3(transform.position.x - movePower, transform.position.y, transform.position.z);
            transform.position = temp;
        }
    }

    /*void Jump()
    {
        jumppingFlug = false;
        rb.AddForce(Vector3.up * 300);
    }*/


    void Down()
    {
        speed -= 1;
        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, speed);
    }

    void OnTriggerEnter(Collider col)
    {
        jumppingFlug = true;

    }
    
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            speed = 0;
        }
    }
}
