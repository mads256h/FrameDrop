using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class tutarolManager : MonoBehaviour {

    public Canvas canvas;
    public Text pressToStart;

    bool pressToStartActivated = false;
    bool enableControls = false;

	// Use this for initialization
	void Start () {
        Invoke("EnablePressToStart", 12);
	
	}
	


	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.Space) && pressToStartActivated)
        {
            canvas.enabled = false;
            canvas.gameObject.SetActive(false);

            enableControls = true;
        }
	
	}


    void EnablePressToStart ()
    {
        pressToStart.enabled = true;
        pressToStart.gameObject.SetActive(true);
        pressToStartActivated = true;

    }
}
