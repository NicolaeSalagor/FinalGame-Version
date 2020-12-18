using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public void GoToMenu()
    {
        SceneManager.LoadScene("Game_Menu");
    }

    public void loadUrl()
    {
        Application.OpenURL("https://github.com/NicolaeSalagor/Final");
    }
    public void LevelOne ()
    {
        SceneManager.LoadScene("LevelOne");
    }

    public void LevelTwo()
    {
        SceneManager.LoadScene("LevelTwo");
    }

    public void LevelThree()
    {
        SceneManager.LoadScene("LevelThree");
    }
    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
    public void Quit()
    {
        SceneManager.LoadScene("Quit");
    }
}
