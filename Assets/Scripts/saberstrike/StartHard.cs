using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartHard : MonoBehaviour
{

    public void LoadHard()
    {
        SceneManager.LoadScene("HardMode");
    }
}
