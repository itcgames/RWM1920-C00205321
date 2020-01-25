using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Reset()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    public void GotoMenu()
    {
        pauseMenuUI.SetActive(false);
        GameIsPaused = false;
        Time.timeScale = 1f;
        GameObject.Find("GameAudio").GetComponent<AudioSource>().Play();
        SceneManager.LoadScene(2);
        
    }

    public void Quit()
    {
        Time.timeScale = 0f;
        GameIsPaused = false;
        Application.Quit();
    }

    public void TestPause()
    {
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void TestResume()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
    }


}
