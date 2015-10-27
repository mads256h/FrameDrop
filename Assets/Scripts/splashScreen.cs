using UnityEngine;
using System.Collections;

public class splashScreen : MonoBehaviour {

    void Start()
    {
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {
        
        yield return new WaitForSeconds(2);
        Application.LoadLevel("MainMenu");
    }
}
