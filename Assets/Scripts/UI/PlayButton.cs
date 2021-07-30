using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadSceneAsync("Element Selection");
    }

    public void Help()
    {
        SceneManager.LoadSceneAsync("Help");
    }
}