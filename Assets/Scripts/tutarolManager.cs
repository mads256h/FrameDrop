using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class tutarolManager : MonoBehaviour {

    public GameObject player;
    public Canvas welcomeCanvas;
    public Text pressToStart;


    bool pressToStartActivated = false;
    

	// Use this for initialization
	void Start () {

		// Invoke Enable Press To Start after 12 secounds
        Invoke("EnablePressToStart", 12);
	
	}
	


	// Update is called once per frame
	void Update () {

		// Check for space or Enter and bool pressToStartActivated
        if ((Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.Return)) && pressToStartActivated)
        {
			// Disable welcomeCanvas
            welcomeCanvas.enabled = false;
            welcomeCanvas.gameObject.SetActive(false);

			// Disable Press To Start
            pressToStart.enabled = false;
            pressToStart.gameObject.SetActive(false);

			// Enable the player
            player.SetActive(true);

        }
	
	}

	// Enable Press To Start Function
    void EnablePressToStart ()
    {
		// Enable Press To Start
        pressToStart.enabled = true;
        pressToStart.gameObject.SetActive(true);

		// Set pressToStartActivated to true
        pressToStartActivated = true;

    }
}
