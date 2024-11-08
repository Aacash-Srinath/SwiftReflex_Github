using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;  // Reference to Score Text UI
    public TextMeshProUGUI timerText;  // Reference to Timer Text UI
    public int score = 0;
    public float timeLimit = 60f;  // 60 seconds time limit
    private bool gameEnded = false;

    void Start()
    {
        UpdateScoreUI();
        UpdateTimerUI();
    }

    void Update()
    {
        if (gameEnded) return;

        // Countdown the timer
        timeLimit -= Time.deltaTime;
        if (timeLimit <= 0 && !gameEnded)
        {
            StartCoroutine(EndGameWithDelay(5));  // Start coroutine for 5 seconds delay
            gameEnded = true;
        }
        UpdateTimerUI();
    }

    public void AddScore(int points)
    {
        if (!gameEnded)
        {
            score += points;
            UpdateScoreUI();
        }
    }

    void UpdateScoreUI()
    {
        scoreText.text = "Score: " + score;
    }

    void UpdateTimerUI()
    {
        timerText.text = "Time: " + Mathf.Max(0, Mathf.FloorToInt(timeLimit)).ToString();
    }

    IEnumerator EndGameWithDelay(float delay)
    {
        // Optionally, you can add any "Game Over" message here
        timerText.text = "Time's up!";

        // Freeze the game by setting time scale to 0
        Time.timeScale = 0;

        // Wait for the specified delay before freezing the game
        yield return new WaitForSeconds(delay);

    }
}
