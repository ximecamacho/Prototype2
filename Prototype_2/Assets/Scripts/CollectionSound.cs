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
        hatCount = 1;
        noseCount = 1;
        scarfCount = 1;
        armsCount = 2;
        buttonsCount = 4;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //audioSource.clip = collectedItem; 

        if (other.gameObject.CompareTag("Arms"))
        {
            if (armsCount > 0)
            {
                //play audio
                audioSource.clip = collectedItem;
                audioSource.Play();
                armsCount = armsCount - 1;
            }
        }
        else if (other.gameObject.CompareTag("Scarfs"))
        {
            if (scarfCount > 0)
            {
                //play audio
                audioSource.clip = collectedItem;
                audioSource.Play();
                scarfCount = scarfCount - 1;
            }
        }
        else if (other.gameObject.CompareTag("Hat"))
        {
            if (hatCount > 0)
            {
                //play audio
                audioSource.clip = collectedItem;
                audioSource.Play();
                hatCount = hatCount - 1;
            }
        }
        else if (other.gameObject.CompareTag("Nose"))
        {
            if (noseCount > 0)
            {
                //play audio
                audioSource.clip = collectedItem;
                audioSource.Play();
                noseCount = noseCount - 1;
            }
        }
        else if (other.gameObject.CompareTag("Button"))
        {
            if (buttonsCount > 0)
            {
                //play audio
                audioSource.clip = collectedItem;
                audioSource.Play();
                buttonsCount = buttonsCount - 1;
            }
        }
    }
}
