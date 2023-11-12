using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using System.Linq;

public class Settings : MonoBehaviour
{
    private AudioMixer audiomixer;

    //param sons
    [SerializeField] Slider musicslider;
    [SerializeField] Slider soundslider;

    public void Start()
    {
        //param sons
        audiomixer.GetFloat("Music", out float musicvalueforslider);
        musicslider.value = musicvalueforslider;

        audiomixer.GetFloat("SoundEff", out float soundvalueforslider);
        soundslider.value = soundvalueforslider;
    }

    public void SetVolume(float volume)
    {
        audiomixer.SetFloat("Music", volume);
    }

    public void SetSoundEffVolume(float volume)
    {
        audiomixer.SetFloat("SoundEff", volume);
    }

    public void SetFullScreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
}