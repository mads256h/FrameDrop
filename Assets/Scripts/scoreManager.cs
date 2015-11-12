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
    public int scoreInt;
    public int fps;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void FixedUpdate() {
        currentX = player.position.x;

        if (currentX > maxX)
        {
            maxX = currentX;
            score = Mathf.Round(maxX * 1000f) / 9000f; // * 1000f;
            scoreInt = (int)score;
            scoreText.text = scoreInt.ToString();
            dieScore.text = "Your score: " + score.ToString();

            fps = (144 - (scoreInt));
            Application.targetFrameRate = fps;
            Debug.Log(fps);
        }

    }
}