using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartEasy : MonoBehaviour
{

    public void LoadEasy()
    {
        SceneManager.LoadScene("EasyMode");
    }
}
