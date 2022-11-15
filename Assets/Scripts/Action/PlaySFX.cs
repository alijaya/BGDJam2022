using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms;

[CreateAssetMenu(menuName = "Unity Atoms/Actions/PlaySFX")]
public class PlaySFX : AtomAction
{
    public AudioClip audioClip;
    public float volume = 1f;

    public override void Do()
    {
        AudioManager.Instance.PlaySFX(audioClip, volume);
    }
}
