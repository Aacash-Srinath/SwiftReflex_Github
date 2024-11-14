using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections;

public class SaberCollision : MonoBehaviour
{
    public TextMeshProUGUI collisionText; // Reference to the TextMeshPro text field
    private int check=0;
    private int levelcheck = 0;
    void Start()
    {
        levelcheck = 0;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag=="Image")
        {
            collisionText.text = "GAME OVER!";
            StartCoroutine(SwitchSceneAfterDelay("gameover", 0.5f));
        }
        else if (other.gameObject.tag == "Middle Object")
        {
            collisionText.text = "Mid point reached";
            check = 1;
        }
        else if (other.gameObject.tag == "End")
        {
            if (check!=1)
            {
                collisionText.text = "Collect the middle sphere to advance to the next level!";
            }
            else
            {
                collisionText.text = "Yay! You have successfully completed the path";
                if (levelcheck == 0)
                {
                    levelcheck = 1;

                    StartCoroutine(SwitchSceneAfterDelay("Level2", 0.5f));
                    
                }
                else if (levelcheck == 1)
                {
                    levelcheck = 2;
                    StartCoroutine(SwitchSceneAfterDelay("Level3", 0.5f));
                    
                }
                else if (levelcheck == 2)
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
