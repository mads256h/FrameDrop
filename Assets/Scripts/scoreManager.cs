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

        // Sætter currentX til spiller positionen
        currentX = player.position.x;

        // Hvis currentX er større end MaxX skal vi køre koden neden under
        if (currentX > maxX)
        {
            // Vi starter med at sætte maxX til CurrentX
            maxX = currentX;
            // Viser scoren som et decimal tal for derefter at gange det op bagefter
            score = Mathf.Round(maxX * 1000f) / 1000f * 1000f;
            // Sætter en score som en intenger i en ny variabel
            scoreInt = (int)score;
            // Sætter scoren på HUD'en til scoren
            scoreText.text = scoreInt.ToString();
            // Sætter scoren på HUD'en når du dør
            dieScore.text = "Your score: " + scoreInt.ToString();

            //Sætter fps'en til ens maxX istedet for score (vi skal holde de to ting seperat)
            fps = (144 - ((int)maxX));
            //Sætter fps'en til unity engine fps
            Application.targetFrameRate = fps;
            //Logs the fps to console
            Debug.Log(fps.ToString());
        }

    }
}