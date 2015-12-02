using UnityEngine;
using System.Collections;

public class shootingManager : MonoBehaviour {

    public Transform shootingPoint;

    public GameObject[] bullets;
    public int machinegunRandomAngleMin = -5;
    public int machinegunRandomAngleMax = 5;

    Quaternion randomAngle;
	
	// Update is called once per frame
	void Update () {
        if (gunManager.ActiveGun != -1)
        {
            if (gunManager.hasGun && gunManager.gunAmmo[gunManager.ActiveGun] >= 0)
            {
                switch (gunManager.ActiveGun)
                {
                    case 0:
                        {
                            if (Input.GetKeyDown(KeyCode.Mouse0))
                                ShootPistol();
                            break;
                        }
                    case 1:
                        {
                            if (Input.GetKey(KeyCode.Mouse0))
                                ShootMachingun();
                            break;
                        }
                    case 2:
                        {
                            if (Input.GetKeyDown(KeyCode.Mouse0))
                                ShootShotgun();
                            break;
                        }
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
        gunManager.gunAmmo[0] -= 1;
        
    }

    public void ShootMachingun()
    {
        if (gunManager.gunAmmo[1] > 0)
        //Instantiate(prefab, at gun);
        randomAngle = Quaternion.Euler(new Vector3(0, 0, Random.Range(machinegunRandomAngleMin, machinegunRandomAngleMax)));
        Instantiate(bullets[0], shootingPoint.position, gunMovement.gunAngle * randomAngle);
        Debug.Log("Shot machinegun");
        gunManager.gunAmmo[1] -= 1;
    }

    public void ShootShotgun()
    {
        if (gunManager.gunAmmo[2] > 0)
        //Instantiate(prefab, at gun)
        Instantiate(bullets[1], shootingPoint.position, gunMovement.gunAngle);
        Debug.Log("Shot shotgun");
        gunManager.gunAmmo[2] -= 1;
    }
}
