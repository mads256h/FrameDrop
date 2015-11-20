using UnityEngine;
using System.Collections;

public class enemyController : MonoBehaviour {

    public Rigidbody enemy;
    public int speed = 100;

    bool right = false;
    Vector3 movement;
    
	
    
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
	void Update () {
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
        if (enemy.velocity.magnitude < speed / 100 || (h <= -0.5))
        {

            // Set the movement vector based on the axis input.
            movement.Set(h, 0f, 0f);

            // Normalise the movement vector and make it proportional to the speed per second.
            movement = movement.normalized * speed * Time.deltaTime;

            // Move the player to it's current position plus the movement.
            enemy.AddForce(transform.right * h * speed * Time.deltaTime);
        }
    }
}
