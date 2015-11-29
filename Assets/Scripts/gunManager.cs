using UnityEngine;
using System.Collections;

public class gunManager : MonoBehaviour {

    public static bool hasGun = false;
    public static int ActiveGun = 0;

    public string[] gunNames;
    public Sprite[] gunSprites;
    public static bool[] gunUnlocked;
    public static int[] gunAmmo;

    int i = 0;
    int currentGun = 0;

	// Use this for initialization
	void Start () {
        hasGun = true;
        gunUnlocked[0] = true;
        gunUnlocked[1] = true;
        gunUnlocked[2] = true;

        Debug.LogError("ALL GUNS ARE ENABLED (DEBUG)");

    }
	
	// Update is called once per frame
	void Update () {
        if (hasGun)
        {
            if (Input.GetAxis("Mouse ScrollWheel") > 0f)
            {
                GunSwitch(true);
            }
            else if (Input.GetAxis("Mouse ScrollWheel") < 0f)
            {
                GunSwitch(false);
            }
        }
	
	}

    void GunSwitch (bool up)
    {
        if (up && hasGun)
        {
            if (currentGun == 0 && gunUnlocked[0])
            {
                ActiveGun = 0;
                currentGun = 1;
                Debug.Log("1");

            }
            if (currentGun == 1 && gunUnlocked[1])
            {
                ActiveGun = 1;
                currentGun = 2;
                Debug.Log("2");
            }
            if (currentGun == 2 && gunUnlocked[2])
            {
                ActiveGun = 2;
                currentGun = 0;
                Debug.Log("3");
            }

        }
        if (!up && hasGun)
        {
            if (currentGun == 0 && gunUnlocked[2])
            {
                ActiveGun = 2;
                currentGun = 2;
                Debug.Log("3");
            }
            if (currentGun == 1 && gunUnlocked[0])
            {
                ActiveGun = 0;
                currentGun = 0;
                Debug.Log("1");
            }
            if (currentGun == 2 && gunUnlocked[1])
            {
                ActiveGun = 1;
                currentGun = 1;
                Debug.Log("2");
            }
        }
    }

    void GunSwitch (int gun)
    {
        if (hasGun)
        {
            if (gun == 0 && gunUnlocked[0])
            {
                ActiveGun = 0;
                currentGun = 0;
                Debug.Log("1");
            }
            if (gun == 1 && gunUnlocked[1])
            {
                ActiveGun = 1;
                currentGun = 1;
                Debug.Log("2");
            }
            if (gun == 2 && gunUnlocked[2])
            {
                ActiveGun = 2;
                currentGun = 2;
                Debug.Log("3");
            }
        }
    }
}
