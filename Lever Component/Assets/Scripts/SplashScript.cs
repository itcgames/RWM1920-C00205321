using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SplashScript : MonoBehaviour
{
    public float timeLimit;
    public Text timerText;
    public float timer = 6;

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < timeLimit)
        {
            SceneManager.LoadScene(1);//Licence Scene
        }
        int time = (int)timer;
        timerText.text = time.ToString();
    }
}
