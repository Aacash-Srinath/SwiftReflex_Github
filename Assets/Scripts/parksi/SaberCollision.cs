using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections;

public class SaberCollision : MonoBehaviour
{
    public TextMeshProUGUI collisionText; // Reference to the TextMeshPro text field
    private int check=0;
    private int levelcheck = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Image"))
        {
            collisionText.text = "GAME OVER!";
            StartCoroutine(SwitchSceneAfterDelay("gameover", 0.5f));
        }
        else if (other.CompareTag("Middle Object"))
        {
            collisionText.text = "Mid point reached";
            check = 1;
        }
        else if (other.CompareTag("End"))
        {
            if (check!=1)
            {
                collisionText.text = "Collect the middle sphere to advance to the next level!";
            }
            else
            {
                collisionText.text = "Yay! You have successfully completed the path";
                if (levelcheck == 1)
                {
                    StartCoroutine(SwitchSceneAfterDelay("Level2", 0.5f));
                    levelcheck++;
                }
                if (levelcheck == 1)
                {
                    StartCoroutine(SwitchSceneAfterDelay("Level3", 0.5f));
                    levelcheck++;
                }
                if (levelcheck == 2)
                {
                    StartCoroutine(SwitchSceneAfterDelay("TheEnd", 0.5f));
                }
            }
            
        }
    }

    private IEnumerator SwitchSceneAfterDelay(string sceneName, float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneName);
    }
}
