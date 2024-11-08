using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallenStarter : MonoBehaviour
{

    public void LoadEasy()
    {
        SceneManager.LoadScene("FallenEasy");
    }
}
