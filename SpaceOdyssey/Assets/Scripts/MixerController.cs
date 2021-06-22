using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MixerController : MonoBehaviour
{
    [SerializeField]
    private AudioMixer mixer;
    [SerializeField]
    private string mixerParameter;
    private void Awake()
    {
        if (PlayerPrefs.HasKey(mixerParameter))
        {
            mixer.SetFloat(mixerParameter, PlayerPrefs.GetFloat(mixerParameter));
        }
        else
        {
            mixer.SetFloat(mixerParameter, 0);
        }
    }
    public void ChangeVolume(float volume)
    {
        mixer.SetFloat(mixerParameter, volume);
        PlayerPrefs.SetFloat(mixerParameter, volume);
    }
}
