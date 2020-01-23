using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonLogic: MonoBehaviour
{
    public void GoToMainMenu()
    {
        this.GetComponent<AudioSource>().Play();
        SceneManager.LoadScene(2);
    }

    public void GoToOptions()
    {
        this.GetComponent<AudioSource>().Play();
        SceneManager.LoadScene(3); //Options
    }

    public void GoToHelp()
    {
        this.GetComponent<AudioSource>().Play();
        SceneManager.LoadScene(4); //Help 
    }

    public void GoToPlay()
    {
        GameObject.Find("GameAudio").GetComponent<AudioSource>().Stop();
        this.GetComponent<AudioSource>().Play();
        SceneManager.LoadScene(5); //Game scene
    }
}
