using UnityEngine;
using System.Collections;

public class splashScreen : MonoBehaviour {

    public int secoundsToLevelChange = 2;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(LoadLevel());
    }

    IEnumerator LoadLevel()
    {
        
        yield return new WaitForSeconds(secoundsToLevelChange);
        Application.LoadLevel("MainMenu");
    }

}
