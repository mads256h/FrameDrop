using UnityEngine;
using System.Collections;

public class keyboardcommands : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKey("Jump"))
    { 
    // inset game start
    }

	
    
    if (Input.GetKey("Cancel")){
    Application.quit(); // For some reason this command doesnt work
    }

    }//End of update

}// END OF CODE
	
