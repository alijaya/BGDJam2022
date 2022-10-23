using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.BaseAtoms;
using System;

[RequireComponent(typeof(AudioSource))]
public class AudioManager : GlobalMB<AudioManager>
{
    public AudioSource audioSource;
    public Dictionary<AudioSource, float> lastTime = new Dictionary<AudioSource, float>();

    public FloatReference bgmVolume;
    public FloatEvent bgmVolumeChanged;

    protected override void SingletonAwakened()
    {
        audioSource = GetComponent<AudioSource>();

        bgmVolume = GlobalRef.instance.bgmVolume;
        bgmVolumeChanged = bgmVolume.GetEvent<FloatEvent>();
        bgmVolumeChanged.Register(UpdateBGMVolume);
        UpdateBGMVolume();
    }

    private void UpdateBGMVolume()
    {
        audioSource.volume = bgmVolume.Value;
    }

    public void PlaySFX(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }

    public void PlayBGM(AudioClip clip)
    {
        if (clip != audioSource.clip)
        {
            lastTime[audioSource] = audioSource.time;
            audioSource.clip = clip;
            if (lastTime.TryGetValue(audioSource, out var time))
            {
                audioSource.time = time;
            }
            audioSource.Play();
        }
    }
}
