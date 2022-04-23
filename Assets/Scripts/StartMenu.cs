using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void PlayGame()
    {
        Loader.Load(Loader.Scene.game_play);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
