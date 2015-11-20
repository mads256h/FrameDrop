using UnityEngine;
using System.Collections;

public class dieMenu : MonoBehaviour {
    public GameObject panel;

	// Restart level function
    public void restartLevel()
    {
		// Set the timescale to the normal timescale
        Time.timeScale = 1;

		// Load the same level we already is in
        Application.LoadLevel(Application.loadedLevel);

		// Disable the panel
        panel.SetActive(false);

		// Disable die in dieScript (We are not dying right now)
        dieScript.isActivated = false;
    }

	// Exit game function
public void exitGame()
    {
		// Exit the application
        Application.Quit();
    }
}
