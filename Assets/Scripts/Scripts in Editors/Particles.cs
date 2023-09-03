using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour
{
    public ParticleSystem particleSystemCoins, particleSystemGems;

    public void PlayParticles()
    {
        particleSystemCoins.Play();   
        particleSystemGems.Play();   
    }

    public void ClearParticles()
    {
        particleSystemCoins.Clear();
        particleSystemGems.Clear();
    }
}