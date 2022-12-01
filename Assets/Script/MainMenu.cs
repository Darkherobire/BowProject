using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private string modeEndless;
    [SerializeField] private string modeTimer;
    [SerializeField] private string mainMenu;

    public void ModeEndless()
    {
        SceneManager.LoadScene(modeEndless);
    }
    
    public void ModeTimer()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(modeTimer);
    }
    
    public void MainScene()
    {
        SceneManager.LoadScene(mainMenu);
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame() 
    {
        Debug.Log("Quiting game...");
        Application.Quit();
    }
}
