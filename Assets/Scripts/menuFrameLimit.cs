using UnityEngine;
using System.Collections;

public class menuFrameLimit : MonoBehaviour {

	public int minFps = 10;
	public int maxFps = 30;

	
	// Update is called once per frame
	void Update () {

		// Set the targetFrameRate to Random value between minFps and maxFps
		Application.targetFrameRate = Random.Range(minFps, maxFps);
       
	}
}
