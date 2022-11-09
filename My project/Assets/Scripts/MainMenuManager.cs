using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Play");
    }

    public void Setting()
    {
        SceneManager.LoadScene("Setting");
    }

    public void Login()
    {
        SceneManager.LoadScene("Login");
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
