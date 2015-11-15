using UnityEngine;
using System.Collections;

public class fpsManager : MonoBehaviour {

    public Camera camera;

    public int startingFps = 300;

    public int lagSpikeChance = 5000;
    public int lagSpikeDuration = 5;
    public bool shake = true;
    public float shakeAmount = 1;
    public Vector3 cameraPosition;


    bool lagSpike = false;
	
	// Update is called once per frame
	void FixedUpdate () {
        if ((Random.Range(0, lagSpikeChance) == 100))
        {
            lagSpike = true;
            Application.targetFrameRate = Random.Range(1, 5);
            Invoke("lagSpikeSet", lagSpikeDuration);
        }
        // Check if targetFramerate is bigger than 1
        if (Application.targetFrameRate > 1 && !lagSpike)
        {
            // Sets the targetFrameRate to 288 - maxX
            Application.targetFrameRate = (300 - ((int)scoreManager.maxX / 2));
        }

        if (lagSpike)
        {
            camera.transform.localPosition = Random.insideUnitSphere * shakeAmount;
        }
        else
        {
            camera.transform.localPosition = cameraPosition;
        }
	}

    void lagSpikeSet ()
    {
        lagSpike = false;
    }
}
