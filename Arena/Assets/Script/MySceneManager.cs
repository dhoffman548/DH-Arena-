using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MySceneManager : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
    public void TitleScreen()
    {
        SceneManager.LoadScene("Title");
    }
}
