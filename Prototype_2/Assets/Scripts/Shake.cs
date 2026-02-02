using System.Collections;
using UnityEngine;

public class Shake : MonoBehaviour
{
    public float duration = 1f;
    public bool start = false;
    public AnimationCurve curve;

    public GameObject cam;
    private PlayerScript camScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         camScript = cam.GetComponent<PlayerScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (camScript.do_I_Start == true)
        {
            start = true;
        }

        if (start)
        {
            start = false;
            StartCoroutine(Shaking());
        }

    }

    IEnumerator Shaking()
    {
        Vector3 startPosition = transform.position;
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float strength = curve.Evaluate(elapsedTime / duration);
            transform.position = startPosition + Random.insideUnitSphere * strength;
            yield return null;
        }

        transform.position = startPosition;
    }

   
}
