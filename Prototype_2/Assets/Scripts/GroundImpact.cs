using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class GroundImpact : MonoBehaviour
{
    private ParticleSystem particles;
    private Transform particlesTransform;

    private AudioSource audioSource;
    [SerializeField] private AudioClip icicleImpact; 

    private void Awake()
    {
        particles = GetComponentInChildren<ParticleSystem>();
        //name of the child Particle System is 'impactParticles'
        particlesTransform = transform.Find("ImpactParticles");
        audioSource = GetComponent<AudioSource>();

    
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("BadItem"))
        {
            other.gameObject.SetActive(false);

            //play audio when the icicle hits the ground 
            audioSource.clip = icicleImpact;
            audioSource.Play();
        }
        
        
        Vector2 newPos = other.contacts[0].point;
        particlesTransform.position = new Vector3(newPos.x, newPos.y, particlesTransform.position.z);
        particles.Play();
    }
}