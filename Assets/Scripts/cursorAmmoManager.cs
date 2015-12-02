using UnityEngine;
using System.Collections;

public class cursorAmmoManager : MonoBehaviour {

    public SpriteRenderer cursorAmmoObject;
    public Sprite[] gunAmmoSprites;


	// Update is called once per frame
	void FixedUpdate () {
	if (gunManager.ActiveGun != -1)
        {
            cursorAmmoObject.sprite = gunAmmoSprites[gunManager.ActiveGun];
        }
	}
}
