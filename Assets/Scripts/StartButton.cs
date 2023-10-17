using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void LoadMainScene()
    {
        // Loads the scene named 'Programming Theory Project Main'.
        SceneManager.LoadScene("Programming Theory Project Main");
    }
}
