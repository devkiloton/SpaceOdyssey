using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    [SerializeField]
    private GameObject pausePanel;
    [SerializeField, Range(0,1)]
    private float timeScalePause;
    private void Update()
    {
        if (touchingScreen())
        {
            continueGame();
        }
        else
        {
            pauseGame();
        }
    }
    private void continueGame()
    {
        pausePanel.SetActive(false);
        timeScale(1);
    }
    private void pauseGame()
    {
        pausePanel.SetActive(true);
        timeScale(timeScalePause);
    }
    private bool touchingScreen()
    {
        return Input.touchCount > 0;
    }
    private void timeScale(float timeScale)
    {
        Time.timeScale = timeScale;
        Time.fixedDeltaTime = 0.02f * Time.timeScale;
    }
}
