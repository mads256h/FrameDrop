using UnityEngine;
using System.Collections;

public class dieScript : MonoBehaviour {

    public Transform player;
    public ParticleSystem particle;
    public Animator anim;
    public GameObject panel;
    public static bool isActivated = false;
    public static bool Activate = false;

    // Update is called once per frame
    void FixedUpdate() {
        if (player.position.y <= -3 && !isActivated || Activate)
        {
            isActivated = true;
            Activate = false;
            particle.enableEmission = true;
            Invoke("Die", 5);

        }
    }

    void Die ()
      {
        panel.SetActive(true);
        anim.SetTrigger("Die");
        Time.timeScale = 0;
    }
    }
