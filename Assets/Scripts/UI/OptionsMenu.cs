using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    [SerializeField] public AudioMixer mainMixer;
    [SerializeField] public Slider volumeSlider = null;

    private void Start()
    {
        //LoadValues();
    }

    public void SetVolume(float sliderValue)
    {
        mainMixer.SetFloat("MasterVolume", Mathf.Log10(sliderValue) * 20);
    }

    public void SaveVolumeButton()
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
    }

    public void SetFullscreen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

}
