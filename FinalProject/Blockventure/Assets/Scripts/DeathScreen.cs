using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    public int sceneToLoad;


    public void TryAgain()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void QuitGame()
    {
        Application.Quit(); //doesn't work in the editor. only works when you make a build
        Debug.Log("Quit Game");
    }
}
