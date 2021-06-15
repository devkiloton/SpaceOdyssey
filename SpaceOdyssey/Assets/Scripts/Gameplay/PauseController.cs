using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    [SerializeField]
    private GameObject pausePanel;
    [SerializeField, Range(0,1)]
    private float timeScalePause;
    private bool stationary;
    private void Update()
    {
        if (touchingScreen())
        {
            if (stationary)
            {
                continueGame();
            }
        }
        else
        {
            if (!stationary)
            {
                pauseGame();
            }
        }
    }
    private void continueGame()
    {
        StartCoroutine(continueGameWithTime());
        stationary = false;
    }
    private void pauseGame()
    {
        pausePanel.SetActive(true);
        timeScale(timeScalePause);
        stationary = true;
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
    private IEnumerator continueGameWithTime()
    {
        yield return new WaitForSecondsRealtime(0.2f);
        pausePanel.SetActive(false);
        timeScale(1);
    }
}
