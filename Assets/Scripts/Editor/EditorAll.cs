using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public static class EditorAll
{
#if UNITY_EDITOR
    [MenuItem("MyEditors/Lista Assets %h")]
    public static void ListaAssets()
    {
        GameObject.Instantiate(Resources.Load<GameObject>("Lista Assets"));
        Debug.LogWarning("Imagem tem que ser associada!");
    }

    [MenuItem("MyEditors/Todas Particles %g")]
    public static void TodasParticles()
    {
        GameObject.Instantiate(Resources.Load<GameObject>("Particles"));
    }

    [MenuItem("MyEditors/Particle Coins %j")]
    public static void ParticleCoins()
    {
        GameObject.Instantiate(Resources.Load<GameObject>("ParticleSystemCoins"));
    }

    [MenuItem("MyEditors/Particle Gems %l")]
    public static void ParticleGems()
    {
        GameObject.Instantiate(Resources.Load<GameObject>("ParticleSystemGems"));
    }
#endif
}