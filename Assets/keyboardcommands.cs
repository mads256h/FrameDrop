using UnityEngine;
using System.Collections;

public class keyboardcommands : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKey(KeyCode.Space))
    { 
    // inset game start
        Application.LoadLevel(3);
    }

	
    
    if (Input.GetKey(KeyCode.Escape)){
    Application.Quit(); // For some reason this command doesnt work
    }

    }//End of update

}// END OF CODE
	
