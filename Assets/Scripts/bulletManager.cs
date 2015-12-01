using UnityEngine;
using System.Collections;

public class bulletManager : MonoBehaviour {

    public int bulletSpeed = 1000;
    public int bulletDamage = 25;

	// Use this for initialization
	void Start () {
	
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
	
	}
}
