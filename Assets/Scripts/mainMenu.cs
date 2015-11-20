using UnityEngine;
using System.Collections;

public class keyboardCommands : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

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
	
