using UnityEngine;
using System.Collections;

public class menuframelimit : MonoBehaviour {

    int fps = 10;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        fps = Random.Range(10, 30);
        Application.targetFrameRate = fps;
       
	}
}
