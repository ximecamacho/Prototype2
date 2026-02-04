using Unity.Burst.Intrinsics;
using UnityEngine;
using UnityEngine.Audio;

public class CollectionSound : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] private AudioClip collectedItem;

    private float armsCount = 2;
    private float scarfCount = 1;
    private float hatCount = 1;
    private float noseCount = 1;
    private float buttonsCount = 4; 

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        audioSource.clip = collectedItem; 

        if (other.gameObject.CompareTag("Arms"))
        {
            if (armsCount > 0)
            {
                armsCount = armsCount - 1;
                //play audio
                audioSource.Play();
            }
        }
        else if (other.gameObject.CompareTag("Scarfs"))
        {
            if (scarfCount > 0)
            {
                scarfCount = scarfCount - 1;
                //play audio
                audioSource.Play();
            }
        }
        else if (other.gameObject.CompareTag("Hat"))
        {
            if (hatCount > 0)
            {
                hatCount = hatCount - 1;
                //play audio
                audioSource.Play();
            }
        }
        else if (other.gameObject.CompareTag("Nose"))
        {
            if (noseCount > 0)
            {
                noseCount = noseCount - 1;
                //play audio
                audioSource.Play();
            }
        }
        else if (other.gameObject.CompareTag("Button"))
        {
            if (buttonsCount > 0)
            {
                //play audio
                audioSource.Play();
                buttonsCount = buttonsCount - 1;
            }
        }
    }
}
