using System.Collections;
using UnityEngine;

public class Shaking : MonoBehaviour
{
    private bool shaking = false;

    [SerializeField] private float shakeAmt;
    [SerializeField] private float shakeTime; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(shaking)
        {
            Vector3 newPos = Random.insideUnitSphere * (Time.deltaTime * shakeAmt);
            //keep original y and z (only shake left and right) 
            newPos.y = transform.position.y;
            newPos.z = transform.position.z;

            transform.position = newPos; 
        }
    }

    public void shakeMe()
    {
        StartCoroutine("ShakeNow");
    }

    IEnumerator ShakeNow()
    {
        Vector3 originalPos = transform.position; 
        if(!shaking)
        {
            shaking = true;
        }

        yield return new WaitForSeconds(shakeTime); //shake for shakeTime, then stop shaking
        shaking = false;
        transform.position = originalPos; //return the object to its original position just in case it has moved 
    }

}
