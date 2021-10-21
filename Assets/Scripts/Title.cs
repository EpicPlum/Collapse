using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
   public void PlayGame()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void PlayCurr()
    {
        SceneManager.LoadScene(moveScene.currLevel);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
