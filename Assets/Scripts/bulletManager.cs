using UnityEngine;
using System.Collections;

public class bulletManager : MonoBehaviour {

    public int bulletSpeed = 1000;
    public int bulletDamage = 25;
    public int bulletAliveTime = 8;

    Rigidbody rigid;
    Vector3 movement;

    // Use this for initialization
    void Start () {
        rigid = this.gameObject.GetComponent<Rigidbody>();
        Invoke("RemoveObject", bulletAliveTime);
	}

    void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            // Insert damage logic
            enemyController enemycontroller = col.gameObject.GetComponent<enemyController>();
            enemycontroller.takeDamage(bulletDamage);

        }

        Destroy(this.gameObject);
    }
	
	// Update is called once per frame
	void Update () {
        Move();
	}

    void Move()
    {


        // if the player is moving under the max speed or going backwards
        if (rigid.velocity.magnitude < bulletSpeed / 100)
        {

            // Set the movement vector based on the axis input.
            movement.Set(1, 0f, 0f);

            // Normalise the movement vector and make it proportional to the speed per second.
            movement = movement.normalized * bulletSpeed * Time.deltaTime;


            // Move the player to it's current position plus the movement.
            rigid.AddRelativeForce(transform.right * 1 * bulletSpeed * Time.deltaTime);

            // Add angle code here
        }
    }

    void RemoveObject()
    {
        Destroy(this.gameObject);
    }
}
