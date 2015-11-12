using UnityEngine;
using System.Collections;

public class dieScript : MonoBehaviour {

    public Transform player;
    public Animator anim;
    public GameObject panel;
    bool isActivated = false;
	
	// Update is called once per frame
	void FixedUpdate () {
        if (player.position.y <= -3 && !isActivated)
        {
            panel.SetActive(true);
            anim.SetTrigger("Die");
            isActivated = true;
            Time.timeScale = 0;
            
            
        }
    }
}
