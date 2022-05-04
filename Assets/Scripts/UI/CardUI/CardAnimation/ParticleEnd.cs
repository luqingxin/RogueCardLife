using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEnd : MonoBehaviour
{
    private ParticleSystem particleSystem;

    private void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
    }

    private void Update()
    {
        if (particleSystem.isStopped)
        {
            Destroy(gameObject);
        }
    }
}
