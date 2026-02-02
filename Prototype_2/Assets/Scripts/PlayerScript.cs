using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    

void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("BadItem"))
        {


            other.gameObject.SetActive(false);
          


        }
        else if (other.gameObject.CompareTag("GoodItem"))
        {

            other.gameObject.SetActive(false);
            

        }
        

        
    }



}
