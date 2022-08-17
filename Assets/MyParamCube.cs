using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyParamCube : MonoBehaviour
{
    [SerializeField] [Range(0, 7)] int band = 0;
    [SerializeField] [Range(0f, 10f)] float animTriggerValue = 1.6f;
    [SerializeField] ParticleSystem particleSystem;
    [SerializeField] ParticleSystem explosion;
    void Update()
    {
        // My Code
        if (AudioPeer.bandBuffer[band] > animTriggerValue)
        {
            gameObject.GetComponent<Animator>().Play("TnkShoot");
            particleSystem.Play();
            explosion.Play();
        }

    }
}