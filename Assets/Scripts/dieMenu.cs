using UnityEngine;
using System.Collections;

public class dieMenu : MonoBehaviour {

public void restartLevel()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

public void exitGame()
    {
        Application.Quit();
    }
}
