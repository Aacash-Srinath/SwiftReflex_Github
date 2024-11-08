using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMedium : MonoBehaviour
{

    public void LoadMedium()
    {
        SceneManager.LoadScene("MediumMode");
    }
}
