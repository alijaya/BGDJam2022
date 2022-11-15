using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class DamageParticle : MonoBehaviour
{
    private ParticleSystem particle;

    public float multiplier = 1;

    private void Awake()
    {
        particle = GetComponent<ParticleSystem>();
    }

    public void SetDamage(int value)
    {
        var burst = particle.emission.GetBurst(0);
        burst.cycleCount = (int)(value * multiplier);
        particle.emission.SetBurst(0, burst);
    }
}
