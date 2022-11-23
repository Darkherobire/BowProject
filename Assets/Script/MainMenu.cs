using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private string menuScene;
    [SerializeField] private string gameScene1;
    [SerializeField] private string gameScene2;

    public void QuitGame() 
    {
        Debug.Log("Quiting game...");
        Application.Quit();
    }
}
