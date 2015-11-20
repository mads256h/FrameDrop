using UnityEngine;
using System.Collections;

public class mainMenu : MonoBehaviour {
	public int minFps = 10;
	public int maxFps = 30;
	
	// Update is called once per frame
	void Update () {

	// Set the targetFrameRate to Random value between minFps and maxFps
	Application.targetFrameRate = Random.Range(minFps, maxFps);

	// if Space 
	if (Input.GetKey(KeyCode.Space))
    { 
    // Load level
        Application.LoadLevel(3);
    }
	
	// if Escape
    if (Input.GetKey(KeyCode.Escape)){
	
	// Exit application
    Application.Quit();
    }

    }

}
	
