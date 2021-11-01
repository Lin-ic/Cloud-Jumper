using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer musicMixer;
    public AudioMixer sfxMixer;


    // Using a Slider, the volume of Music can be set
    public void SetVolume(float volume)
    {
        musicMixer.SetFloat("Volume", volume);
    }

    // Using a Slider, the volume of SFX can be set
    public void SetVolumeSFX(float volume)
    {
        sfxMixer.SetFloat("sfx", volume);
    }

}