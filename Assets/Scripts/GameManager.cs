using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject options;
    public bool isPaused = false;

    public FreeLookCamera freeLookCamera;

    public GameObject car;
    public GameObject[] parkingLevels;

    public UnityEvent OnResume;
    public UnityEvent OnPause;

    // Start is called before the first frame update
    void Start()
    {
        GameObject currentLevel = parkingLevels[PlayerPrefs.GetInt("LevelNumber") - 1];
        currentLevel.SetActive(true);
        Transform spawnPoint = currentLevel.transform.GetChild(0);
        GameObject currentCar = Instantiate(car, spawnPoint.position, spawnPoint.rotation);

        if (freeLookCamera != null)
        {
            freeLookCamera.SetTarget(currentCar.transform.Find("CameraLookAt"));
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                OnResume?.Invoke();
                isPaused = false;
            }
            else
            {
                OnPause?.Invoke();
                isPaused = true;
            }
        }
    }

    public void PauseTheGame()
    {
        Time.timeScale = 0f;
    }

    public void ResumeTheGame()
    {
        Time.timeScale = 1f;
    }

    public void Options()
    {
        options.SetActive(true);
    }

    public void Back()
    {
        options.SetActive(false);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }

    public void Home()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
    }

    public void NextLevel()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
    }

    public void LevelUnlock()
    {
        if(PlayerPrefs.GetInt("LevelNumber") >= PlayerPrefs.GetInt("LevelComplete"))
        {
            PlayerPrefs.SetInt("LevelComplete", PlayerPrefs.GetInt("LevelNumber"));
        }
    }
}
