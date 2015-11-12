using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class scoreManager : MonoBehaviour {

    public Transform player;
     float maxX = 0;
     float currentX = 0;

    public Text scoreText;
    public Text dieScore;
    public float score = 0;
     

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        currentX = player.position.x;

        if (currentX > maxX)
        {
            maxX = currentX;
            score = Mathf.Round(maxX * 1000f) / 1000f * 1000f;
            scoreText.text = score.ToString();
            dieScore.text = "Your score: " + score.ToString();
            
        }
	
	}
}
