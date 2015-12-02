using UnityEngine;
using System.Collections;

public class courserAmmoManager : MonoBehaviour {

    public SpriteRenderer courserAmmoObject;
    public Sprite[] gunAmmoSprites;


	// Update is called once per frame
	void FixedUpdate () {
	if (gunManager.ActiveGun != -1)
        {
            courserAmmoObject.sprite = gunAmmoSprites[gunManager.ActiveGun];
        }
	}
}
