using UnityEngine;
using System.Collections;

public class enemyController : MonoBehaviour {

    public int speed = 100;
    public int startingHealth = 100;

    Rigidbody rigid;
    int Health = 0;
    bool right = false;
    Vector3 movement;
    
	void Start()
    {
        rigid = this.gameObject.GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "SwitchDir")
        {
        if (right)
            {
                right = false;
            }
        else
            {
                right = true;
            }
        }
    }
    
	
	// Update is called once per frame
	void FixedUpdate () {
        if (right)
        {
            Move(1);
        }
        else
        {
            Move(-1);
        }
	
	}

    void Move(float h)
    {
        

        // if the player is moving under the max speed or going backwards
        if (rigid.velocity.magnitude < speed / 100)
        {

            // Set the movement vector based on the axis input.
            movement.Set(h, 0f, 0f);

            // Normalise the movement vector and make it proportional to the speed per second.
            movement = movement.normalized * speed * Time.deltaTime;

            
            // Move the player to it's current position plus the movement.
            rigid.AddForce(transform.right * h * speed * Time.deltaTime);
        }
    }

    public void takeDamage(int damage)
    {
        Health -= damage;
        if (Health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
