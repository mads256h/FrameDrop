using UnityEngine;
using System.Collections;

public class dieScript : MonoBehaviour {

    public Transform player;
    public Animator anim;
    public GameObject panel;
    public static bool isActivated = false;
    public static bool Activate = false;
	
	// Update is called once per frame
	void FixedUpdate () {
        if (player.position.y <= -3 && !isActivated || Activate)
        {
            panel.SetActive(true);
            anim.SetTrigger("Die");
            isActivated = true;
            Activate = false;
            Time.timeScale = 0;
            
            
        }
    }
}
