using UnityEngine;
using System.Collections;

public class fpsManager : MonoBehaviour {

    public Camera mainCamera;

    public int startingFps = 300;

    public int lagSpikeChance = 5000;
    public int lagSpikeDuration = 5;

    bool lagSpike = false;
	
	// Update is called once per frame
	void FixedUpdate () {

        // Generate a random number, if the random number is 0 then Lagspike
        if ((Random.Range(0, lagSpikeChance) == 0) && !lagSpike)
        {
            // Set the bool lagspike to true
            lagSpike = true;

            // Invoke the function "lagSpikeSet" after "lagSpikeDuration"
            Invoke("lagSpikeSet", lagSpikeDuration);
        }

        // Check if targetFramerate is bigger than 1
        if (Application.targetFrameRate > 1 && !lagSpike)
        {
            // Sets the targetFrameRate to 288 - maxX
            Application.targetFrameRate = (300 - ((int)scoreManager.maxX / 2));
        }

        // If "lagSpike" is true
        if (lagSpike)
        {
            // Set the framerate to a random framerate (lagspike like)
            Application.targetFrameRate = Random.Range(1, 5);
        }
	}

    void lagSpikeSet ()
    {
        lagSpike = false;
    }
}
