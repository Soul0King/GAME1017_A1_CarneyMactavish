using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    [SerializeField] GameObject volumeSliderg;

    [SerializeField] GameObject bButton;
    [SerializeField] GameObject mainController;

    

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }
        else
        {
            Load();
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        volumeSliderg.SetActive(true);
        bButton.SetActive(true);
    }
    public void ResumeGame()
    {
        Time.timeScale = 1f;
        volumeSliderg.SetActive(false);
        bButton.SetActive(false);
    }

    public void ChangeVolume()
    {
        mainController.GetComponent<AudioSource>().volume = volumeSlider.value;
        //AudioListener.volume = volumeSlider.value;
        Save();
    }

    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }
}
