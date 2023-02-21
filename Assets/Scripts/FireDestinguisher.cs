using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FireDestinguisher : MonoBehaviour
{
    ParticleSystem particleSystem_;

    private void Start()
    {
        particleSystem_ = GetComponentsInChildren<ParticleSystem>()[0];
    }

    public void On()
    {
        particleSystem_.Play();
    }

    public void Off()
    {
        particleSystem_.Stop();
    }
}
