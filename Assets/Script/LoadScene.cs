using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void LoadScene01() 
    {
        SceneManager.LoadScene("MINIGAME_Endless");
    }
}
