using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject[] levelButtons;

    public TMP_Dropdown dropDownGraphics;
    public Slider masterVol;
    public AudioMixer audioMixer;

    public UnityEvent OnBackClick;
    public UnityEvent OnPlayClick;
    public UnityEvent OnOptionClick;


    // Start is called before the first frame update
    void Start()
    {
        LevelUnlockCheck();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Back()
    {
        OnBackClick?.Invoke();
    }

    public void Play()
    {
        OnPlayClick?.Invoke();
    }

    public void Option()
    {
        OnOptionClick?.Invoke();
    }

    public void Exit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void ChangeGraphicsQuality()
    {
        QualitySettings.SetQualityLevel(dropDownGraphics.value);
    }

    public void ChangeMasterVolume()
    {
        audioMixer.SetFloat("Master", masterVol.value);
    }

    public void LevelSelect(int levelNo)
    {
        PlayerPrefs.SetInt("LevelNumber", levelNo);
        SceneManager.LoadScene("GamePlay");
    }


    public void LevelUnlockCheck()
    {
        int levelComplete = PlayerPrefs.GetInt("LevelComplete");

        for (int i = 0; i < levelButtons.Length; i++)
        {
            if (i < levelComplete)
            {
                levelButtons[i].transform.GetChild(1).gameObject.SetActive(false);
            }
            else
            {
               levelButtons[i].transform.GetChild(1).gameObject.SetActive(true);
            }
        }
    }
}
