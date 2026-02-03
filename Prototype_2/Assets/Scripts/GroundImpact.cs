using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class GroundImpact : MonoBehaviour
{
    private ParticleSystem particles;
    private Transform particlesTransform;
    private void Awake()
    {
        particles = GetComponentInChildren<ParticleSystem>();
        //name of the child Particle System is 'groundParticles'
        particlesTransform = transform.Find("ImpactParticles");
    }
    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("BadItem"))
        {
            other.gameObject.SetActive(false);
        }
        
        Vector2 newPos = other.contacts[0].point;
        particlesTransform.position = new Vector3(newPos.x, newPos.y, particlesTransform.position.z);
        particles.Play();
    }
}