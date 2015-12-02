using UnityEngine;
using System.Collections;

public class shootingManager : MonoBehaviour {

    public Transform shootingPoint;
    public Transform target;

    public GameObject[] bullets;
    public int machinegunRandomAngleMin = -5;
    public int machinegunRandomAngleMax = 5;

    Ray ray;
    RaycastHit hit;
    Quaternion randomAngle;
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey("Fire1") && gunManager.hasGun && gunManager.gunAmmo[gunManager.ActiveGun] >= 0)
        {
            switch (gunManager.ActiveGun)
            {
                case 0:
                    {
                        ShootPistol();
                        break;
                    }
                case 1:
                    {
                        ShootMachingun();
                        break;
                    }
                case 2:
                    {
                        ShootShotgun();
                        break;
                    }
            }
        }
	
	}

    public void ShootPistol()
    {
        if (gunManager.gunAmmo[0] > 0)
        
            //Instantiate(prefab, at gun);
            Instantiate(bullets[0], shootingPoint.position, gunMovement.gunAngle);
            Debug.Log("Shot pistol");
        
    }

    public void ShootMachingun()
    {
        if (gunManager.gunAmmo[1] > 0)
        //Instantiate(prefab, at gun);
        randomAngle = Quaternion.Euler(new Vector3(0, 0, Random.Range(machinegunRandomAngleMin, machinegunRandomAngleMax)));
        Instantiate(bullets[0], shootingPoint.position, gunMovement.gunAngle * randomAngle);
        Debug.Log("Shot machinegun");
    }

    public void ShootShotgun()
    {
        if (gunManager.gunAmmo[2] > 0)
        //Instantiate(prefab, at gun)
        Instantiate(bullets[1], shootingPoint.position, gunMovement.gunAngle);
        Debug.Log("Shot shotgun");
    }
}
