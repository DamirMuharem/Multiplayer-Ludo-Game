using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip ButtonAudioClip;
    public AudioClip DismissalAudioClip;
    public AudioClip DiceAudioClip;
    public AudioClip WinnerAudioClip;
    public AudioClip SafeHouseAudioClip;
    public AudioClip PlayerAudioClip;
    
    public static AudioSource ButtonAudioSource;
    public static AudioSource DismissalAudioSource;
    public static AudioSource DiceAudioSource;
    public static AudioSource WinnerAudioSource;
    public static AudioSource SafeHouseAudioSource;
    public static AudioSource PlayerAudioSource;


    AudioSource AddAudio(AudioClip clip, bool PlayOnAwake, bool loop, float volume)
    {
        AudioSource audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = clip;
        //audioSource.PlayOnAwake = PlayOnAwake;
        audioSource.loop = loop;
        audioSource.volume = volume;
        return audioSource;
    }

    // Start is called before the first frame update
    void Start()
    {
        ButtonAudioSource = AddAudio(ButtonAudioClip, false, false, 1.0f);
        DismissalAudioSource = AddAudio(DismissalAudioClip, false, false, 1.0f);
        DiceAudioSource = AddAudio(DiceAudioClip, false, false, 1.0f);
        WinnerAudioSource = AddAudio(WinnerAudioClip, false, false, 1.0f);
        SafeHouseAudioSource = AddAudio(SafeHouseAudioClip, false, false, 1.0f);
        PlayerAudioSource = AddAudio(PlayerAudioClip, false, false, 1.0f);
        
    }

}
