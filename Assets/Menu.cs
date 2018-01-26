using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

    public GameObject SettingsMenu;
    public bool SettingPopup;
    public Slider volumeSlider;
    public AudioSource volumeAudio;

    void Update ()
    {
        if (SettingPopup == true)
        {
            SettingsMenu.SetActive(true);
        }
        if (SettingPopup == false)
        {
            SettingsMenu.SetActive(false);
        }
    }
    public void VolumeController()
    {
        volumeAudio.volume = volumeSlider.value;
    }

    public void OpenSettings()
    {
        SettingPopup = true;
    }
    public void CloseSettings()
    {
        SettingPopup = false;
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Play(string LevelName)
    {
        Application.LoadLevel(LevelName);
    }
}
