using UnityEngine;
using System.Collections;

public class characterController : MonoBehaviour {

    public Rigidbody rigid;
    public int Speed;
    public int jumpSpeed;
    public bool grounded = true;

    Vector3 movement;
    Vector3 movementJump;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Default"))
        {
            grounded = true;
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Death")
        {
            dieScript.Activate = true;
        }
    }

    void FixedUpdate()
    {
        // Store the input axes.
        float h = Input.GetAxisRaw("Horizontal");
        bool v = Input.GetKeyDown(KeyCode.Space);

        // Move the player around the scene.

        Move(h);

        if (v && grounded)
        {
            Jump();
        }
    }

    void Move(float h)
    {
        if (rigid.velocity.magnitude < Speed / 100)
        {
            // Set the movement vector based on the axis input.
            movement.Set(h, 0f, 0f);

            // Normalise the movement vector and make it proportional to the speed per second.
            movement = movement.normalized * Speed * Time.deltaTime;

            // Move the player to it's current position plus the movement.
            rigid.AddForce(transform.right * h * Speed * Time.deltaTime);
        }
    }

    void Jump()
    {
        rigid.AddForce(transform.up * jumpSpeed);
        grounded = false;
    }
}
