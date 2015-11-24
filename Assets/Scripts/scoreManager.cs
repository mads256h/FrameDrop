using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class scoreManager : MonoBehaviour {
    public Transform player;
    public static float maxX = 0;
    public static float currentX = 0;

    public Text scoreText;
    public Text dieScore;
    public static float score = 0;

    // Called when loaded
    void Start()
    {
        // Reset to default values
        maxX = 0;
        currentX = 0;
        score = 0;
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
            score = Mathf.Round(maxX * 1000f) - 2500;

            // Sætter scoren på HUD'en til scoren
            scoreText.text = score.ToString();

            // Sætter scoren på HUD'en når du dør
            dieScore.text = "Your score: " + score.ToString();
        }

    }
}