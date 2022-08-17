using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyParamCubeMLRS : MonoBehaviour
{
    [SerializeField] [Range(0, 7)] int band = 0;
    [SerializeField] [Range(0f, 10f)] float animTriggerValue = 1.6f;
    [SerializeField] ParticleSystem particleSystem;
    [SerializeField] GameObject rocket;
    [SerializeField] GameObject parent;

    void Update()
    {
        // My Code
        if (AudioPeer.bandBuffer[band] > animTriggerValue)
        {
            gameObject.GetComponent<Animator>().Play("MLRSShoot");
            particleSystem.Play();
            //LaunchRocket();
        }

    }

    private void LaunchRocket()
    {
        GameObject newRocket = Instantiate(rocket, parent.transform);
        DestroyObject(newRocket, 1f);
    }
}
