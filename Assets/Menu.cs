using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public GameObject settingsMenu;
    public bool settingPopup;
    public Slider volumeSlider;
    public AudioSource volumeAudio;

    void Update ()
    {

    }
    public void VolumeController()
    {
        volumeAudio.volume = volumeSlider.value;
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Play(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}
