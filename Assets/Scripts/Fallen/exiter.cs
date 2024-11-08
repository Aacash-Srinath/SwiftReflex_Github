using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using TMPro;
using UnityEngine.Rendering.Universal.Internal;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverUI;  // Assign the Game Over UI Canvas in the Inspector
    public GameObject SaberControllers;
    public GameObject MenuControllers;
    public string sceneToLoad;  // Scene name or index to reload (e.g., current game scene)
    public string mainMenuScene;  // Scene name for the main menu

    void Start()
    {
        // Ensure the Game Over UI is initially disabled
        gameOverUI.SetActive(false);
        MenuControllers.SetActive(false);
        StartCoroutine(WaitAndShowGameOver());
    }

    // Coroutine to wait for 15 seconds before showing Game Over
    private IEnumerator WaitAndShowGameOver()
    {
        yield return new WaitForSeconds(15);  // Wait 15 seconds
        ShowGameOver();  // Show the Game Over screen
    }

    // Call this method to display the Game Over screen
    public void ShowGameOver()
    {
        gameOverUI.SetActive(true);  // Show the Game Over UI
        MenuControllers.SetActive(true);
        SaberControllers.SetActive(false);
        Time.timeScale = 0;  // Pause the game
    }

    // Restart the current game scene
    public void RestartGame()
    {
        Time.timeScale = 1;  // Resume the game
        SceneManager.LoadScene(sceneToLoad);  // Reload the specified scene
    }

    // Load the main menu scene
    public void LoadMainMenu()
    {
        Time.timeScale = 1;  // Resume the game
        SceneManager.LoadScene(mainMenuScene);  // Load the main menu scene
    }
}
