using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static int score = 0;
    [SerializeField] TextMeshProUGUI scoreText;

    // Method to increase the score
    public static void AddScore(int points)
    {
        score += points;
    }

    // Method to reset the score
    public static void ResetScore()
    {
        score = 0;
    }

    private void Update()
    {
        scoreText.text = "Score: " + ScoreManager.score;
    }
}
