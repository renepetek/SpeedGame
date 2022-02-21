using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
   
    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void ExitGame()
    {
        Debug.Log("QITING");
        Application.Quit();
    }
}
