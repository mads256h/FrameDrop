using UnityEngine;
using System.Collections;

public class splashScreen : MonoBehaviour {
    public AudioSource audioSource;
    public float waitSecounds = 2;
    public float waitChangelevel = 3;


    //The script starts here
    void Start()
    {
        // Call the function "playSound" after the amount of secounds specified by "waitSecounds"
        Invoke("playSound", waitSecounds);

        // Call the function "changeLevel" after the amount of secounds specified by "waitChangelevel"
        Invoke("changeLevel", waitChangelevel );
        
    }

    void playSound()
    {
        // Play the sound in the audioSource
        audioSource.Play();
    }

    void changeLevel()
    {
        // Change the level to "MainMenu"
        Application.LoadLevel("MainMenu");
    }
}
