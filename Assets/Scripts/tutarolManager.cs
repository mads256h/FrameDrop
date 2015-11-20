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
        Invoke("EnablePressToStart", 12);
	
	}
	


	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.Space) && pressToStartActivated)
        {
            welcomeCanvas.enabled = false;
            welcomeCanvas.gameObject.SetActive(false);
            pressToStart.enabled = false;
            pressToStart.gameObject.SetActive(false);

            player.SetActive(true);
        }
	
	}


    void EnablePressToStart ()
    {
        pressToStart.enabled = true;
        pressToStart.gameObject.SetActive(true);
        pressToStartActivated = true;

    }
}
