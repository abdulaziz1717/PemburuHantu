using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    [SerializeField] public AudioMixer mainMixer;
    [SerializeField] public Slider volumeSlider;
    public float volume = 1f;

    public const string keyVolume = "VOLUME";

    private void Start()
    {
        float previousVolume = PlayerPrefs.GetFloat(keyVolume);
        SetVolume(previousVolume);
        volumeSlider.value = previousVolume;
        //LoadValues();
    }

    public void SetVolume(float sliderValue)
    {
        volume = sliderValue;
        mainMixer.SetFloat("MasterVolume", Mathf.Log10(sliderValue) * 20);

        PlayerPrefs.SetFloat(keyVolume, sliderValue);
    }

    /*public void SaveVolumeButton()
    {
        float volumeValue = volumeSlider.value;
        PlayerPrefs.SetFloat("VolumeValue", volumeValue);
        LoadValues();
    }

    void LoadValues()
    {
        float volumeValue = PlayerPrefs.GetFloat("VulumeValue");
        volumeSlider.value = volumeValue;
        AudioListener.volume = volumeValue;
    }*/

    //----------------SET FULLSCREEN-------------------------//

    public void SetFullscreen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

}
