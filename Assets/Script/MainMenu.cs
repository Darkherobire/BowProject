using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private string modeEndless;
    [SerializeField] private string modeTimer;

    public void ModeEndless()
    {
        SceneManager.LoadScene(modeEndless);
    }
    
    public void ModeTimer()
    {
        SceneManager.LoadScene(modeTimer);
    }
    
    public void QuitGame() 
    {
        Debug.Log("Quiting game...");
        Application.Quit();
    }
}
