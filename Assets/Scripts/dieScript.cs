using UnityEngine;
using System.Collections;

public class dieScript : MonoBehaviour {

    public Transform player;
    public ParticleSystem particle;
    public Animator anim;
    public GameObject panel;
    public static bool isActivated = false;
    public static bool Activate = false;

    // Fixed update is called 60 times every secound
    void FixedUpdate() {

		// if the players position is under -3 and is not activated or activate is true
        if (player.position.y <= -4 && !isActivated || Activate)
		{
			// Enable the panel
            panel.SetActive(true);

			// Set the trigger Die
            anim.SetTrigger("Die");

			// Set isActivated to true to not execute this program over and over again
            isActivated = true;

			// Set Activate to false
            Activate = false;

			// Set the timeScale to 0 to stop execution of scripts and stop the score from counting up
            Time.timeScale = 0;

        }
    }
    }
