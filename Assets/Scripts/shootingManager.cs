using UnityEngine;
using System.Collections;

public class shootingManager : MonoBehaviour {

    public Transform shootingPoint;
    public Transform target;

    public GameObject bullet;

    Ray ray;
    RaycastHit hit;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey("Fire1") && gunManager.hasGun && gunManager.gunAmmo[gunManager.ActiveGun] > 0)
        {

        }
	
	}

    void ShootPistol()
    {
        //Instantiate(prefab, at gun);
        Debug.Log("LEL");
    }
}
