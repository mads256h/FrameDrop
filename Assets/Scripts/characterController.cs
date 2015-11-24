using UnityEngine;
using System.Collections;

public class characterController : MonoBehaviour {

    public Rigidbody rigid;
    public int Speed;
    public int jumpSpeed;
    public bool grounded = true;

    
    Vector3 movement;



	// On collision enter if the player is hitting an object set grounded to true
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Default"))
        {
            grounded = true;
        }

    }

	// On trigger enter, used to kill the player on spikes
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Death")
        {
            dieScript.Activate = true;
        }
    }

    // Update is called every frame
    void Update()
    {
        
        // Store the input axes.
        float h = Input.GetAxisRaw("Horizontal");
        bool v = Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetAxisRaw("Jump") >= 0.75;

        // Move the player around the scene.
        Move(h);

		// if v and grounded is true jump
        if (v && grounded)
        {
			// Jump Function
            Jump();
        }
    }

    // The move function
    void Move(float h)
    {
		// if the player is moving under the max speed or going backwards
		if (rigid.velocity.magnitude < Speed / 100 || (h <= -0.5))
        {

            // Set the movement vector based on the axis input.
            movement.Set(h, 0f, 0f);

            // Normalise the movement vector and make it proportional to the speed per second.
            movement = movement.normalized * Speed * Time.deltaTime;

            // Move the player to it's current position plus the movement.
            rigid.AddForce(transform.right * h * Speed * Time.deltaTime);
        }
    }

    // The Jump function
    void Jump()
    {
		// Add force upwards to the player at the jumpSpeed
        rigid.AddForce(transform.up * jumpSpeed);

		// Set the grounded bool to false
        grounded = false;
    }
}
