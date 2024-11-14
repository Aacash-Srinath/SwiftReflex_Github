using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class menu : MonoBehaviour
{
    public string scenetoLoad;
    public string mainmenu;
    public void Restart()
    {
        SceneManager.LoadScene(scenetoLoad);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(mainmenu);

    }
}
