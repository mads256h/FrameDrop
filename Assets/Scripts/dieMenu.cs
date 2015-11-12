using UnityEngine;
using System.Collections;

public class dieMenu : MonoBehaviour {
    public GameObject panel;
    public void restartLevel()
    {
        Time.timeScale = 1;
        Application.LoadLevel(Application.loadedLevel);
        panel.SetActive(false);
        dieScript.isActivated = false;
    }

public void exitGame()
    {
        Application.Quit();
    }
}
