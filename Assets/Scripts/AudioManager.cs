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

    public FloatReference bgmVolume;
    public FloatEvent bgmVolumeChanged;

    public FloatReference sfxVolume;
    public FloatEvent sfxVolumeChanged;

    protected override void SingletonAwakened()
    {
        bgmSource = gameObject.AddComponent<AudioSource>();
        sfxSource = gameObject.AddComponent<AudioSource>();

        bgmVolume = GlobalRef.instance.bgmVolume;
        bgmVolumeChanged = bgmVolume.GetEvent<FloatEvent>();
        bgmVolumeChanged.Register(UpdateBGMVolume);
        UpdateBGMVolume();

        sfxVolume = GlobalRef.instance.sfxVolume;
        sfxVolumeChanged = sfxVolume.GetEvent<FloatEvent>();
        sfxVolumeChanged.Register(UpdateSFXVolume);
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

    public void PlaySFX(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
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
