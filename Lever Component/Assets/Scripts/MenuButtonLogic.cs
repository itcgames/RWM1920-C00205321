using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonLogic: MonoBehaviour
{
    public void GoToMainMenu()
    {
        SceneManager.LoadScene(2);
    }

    public void GoToOptions()
    {
        SceneManager.LoadScene(3); //Options
    }

    public void GoToHelp()
    {
        SceneManager.LoadScene(4); //Help 
    }

    public void GoToPlay()
    {
        SceneManager.LoadScene(5); //Game scene
    }
}
