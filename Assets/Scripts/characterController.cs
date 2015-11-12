using UnityEngine;
using System.Collections;

public class characterController : MonoBehaviour {

    public Rigidbody rigid;
    public int Speed;
    public int jumpSpeed;
    public bool grounded = true;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Default"))
        {
            grounded = true;
        }
    }

    // Update is called once per frame
    void FixedUpdate () {
        if (rigid.velocity.magnitude < Speed)
        {
            if (Input.GetKey(KeyCode.A))
            {
                rigid.AddForce(-transform.right * Speed);
            }
           
                if (Input.GetKeyDown(KeyCode.Space) && grounded)
                {
                    rigid.AddForce(transform.up * jumpSpeed);
                    grounded = false;
                }
            
            if (Input.GetKey(KeyCode.D))
            {
                rigid.AddForce(transform.right * Speed);
            }
        }

    }
}
