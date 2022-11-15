using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.BaseAtoms;
using System;

public class AudioManager : GlobalMB<AudioManager>
{
    public AudioSource bgmSource;
    public AudioSource sfxSource;
    public Dictionary<AudioSource, float> lastTime = new Dictionary<AudioSource, float>();

    public FloatVariable bgmVolume;

    public FloatVariable sfxVolume;

    protected override void SingletonAwakened()
    {
        bgmVolume.Changed.Register(UpdateBGMVolume);
        UpdateBGMVolume();

        sfxVolume.Changed.Register(UpdateSFXVolume);
        UpdateSFXVolume();
    }

    private void UpdateBGMVolume()
    {
        bgmSource.volume = bgmVolume.Value;
    }

    private void UpdateSFXVolume()
    {
        sfxSource.volume = sfxVolume.Value;
    }

    public void PlaySFX(AudioClip clip, float volume = 1f)
    {
        sfxSource.PlayOneShot(clip, volume);
    }

    public void PlayBGM(AudioClip clip)
    {
        if (clip != bgmSource.clip)
        {
            lastTime[bgmSource] = bgmSource.time;
            bgmSource.clip = clip;
            if (lastTime.TryGetValue(bgmSource, out var time))
            {
                bgmSource.time = time;
            }
            bgmSource.Play();
        }
    }
}
