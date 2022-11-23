using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private string menuScene;
    [SerializeField] private string gameScene1;
    [SerializeField] private string gameScene2;

    private void MainMenuScene()
    {
        SceneManager.LoadScene(menuScene);
    }

    private void GameModeEndless()
    {
        SceneManager.LoadScene(gameScene1);
    }

    private void GameModeTimer()
    {
        Debug.Log("Game game...");
        SceneManager.LoadScene(gameScene2);
    }
    
    public void QuitGame() 
    {
        Debug.Log("Quiting game...");
        Application.Quit();
    }
}
