using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    enum Screen
    {
        Main,
        Settings,
        Select
    }

    public CanvasGroup mainScreen;
    public CanvasGroup settingsScreen;
    public CanvasGroup lvlScreen;


    public string sceneName;

    private void SetCurrentScreen(Screen screen)
    {
        Utility.SetCanvasGroupEnabled(mainScreen, screen == Screen.Main);
        Utility.SetCanvasGroupEnabled(settingsScreen, screen == Screen.Settings);
        Utility.SetCanvasGroupEnabled(lvlScreen, screen == Screen.Select);
    }
    
    void Start()
    {
        SetCurrentScreen(Screen.Main);
    }

    public void StartNewGame()
    {
        SceneManager.LoadScene(sceneName);
    }
    public void LoadLvl1()
    {
        SceneManager.LoadScene("lvl1");
    }

    public void LoadLvl2()
    {
        SceneManager.LoadScene("lvl2");
    }

    public void OpenSettings()
    {
        SetCurrentScreen(Screen.Settings);
    }

    public void GoToMain()
    {
        SetCurrentScreen(Screen.Main);
    }

    public void SelectLevel()
    {
        SetCurrentScreen(Screen.Select);
    }


    public void ExitGame()
    {
        Application.Quit();
    }

}
