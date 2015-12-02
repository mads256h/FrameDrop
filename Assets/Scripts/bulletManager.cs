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

        rigid.velocity = transform.right * bulletSpeed * Time.deltaTime;

    }

    void RemoveObject()
    {
        Destroy(this.gameObject);
    }
}
