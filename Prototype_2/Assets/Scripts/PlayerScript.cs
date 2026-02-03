using Unity.VisualScripting;
using TMPro;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public TextMeshProUGUI hatText;
    public TextMeshProUGUI noseText;
    public TextMeshProUGUI scarfText;
    public TextMeshProUGUI armText;
    public TextMeshProUGUI buttonText;

    public GameObject winTextObject;
    
    public bool do_I_Start = false;

    public int hatCount = 1;
    public int noseCount = 1;

    public int scarfCount = 2;
    public int armsCount = 2;
    public int buttonsCount = 2;

   
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 1f;
        hatCount = 1;
        noseCount = 1;
        scarfCount = 2;
        armsCount = 2;
        buttonsCount = 2;
        SetScoreText();
        winTextObject.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
       
        


    }
    void SetScoreText()
    {
        hatText.text = hatCount.ToString();
        noseText.text = noseCount.ToString();
        scarfText.text = scarfCount.ToString();
        armText.text = armsCount.ToString();
        buttonText.text = buttonsCount.ToString();
  
        
        if ((hatCount + noseCount + scarfCount + armsCount + buttonsCount) == 0)
        {
             winTextObject.SetActive(true);
             Time.timeScale = 0f;
        }
    }


    void OnTriggerEnter2D(Collider2D other)
    {




        if (other.gameObject.CompareTag("BadItem"))
        {
            do_I_Start = true;


            other.gameObject.SetActive(false);
            Time.timeScale = 0f;



        }
        else if (other.gameObject.CompareTag("Hat"))
        {
            if (hatCount > 0)
            {
                hatCount = hatCount - 1;
            }
            SetScoreText();
            other.gameObject.SetActive(false);


        }
        else if (other.gameObject.CompareTag("Arms"))
        {
            if (armsCount > 0)
            {
                armsCount = armsCount - 1;
            }
            SetScoreText();
            other.gameObject.SetActive(false);


        }
        else if (other.gameObject.CompareTag("Scarfs"))
        {
            if (scarfCount > 0)
            {
                scarfCount = scarfCount - 1;
            }
            SetScoreText();
            other.gameObject.SetActive(false);


        }
        else if (other.gameObject.CompareTag("Hat"))
        {
            if (hatCount > 0)
            {
                hatCount = hatCount - 1;
            }
            SetScoreText();
            other.gameObject.SetActive(false);


        }
        else if (other.gameObject.CompareTag("Nose"))
        {
            if (noseCount > 0)
            {
                noseCount = noseCount - 1;
            }
            SetScoreText();
            other.gameObject.SetActive(false);


        }
        else if (other.gameObject.CompareTag("Button"))
        {
            if (buttonsCount > 0)
            {
                buttonsCount = buttonsCount - 1;
            }
            SetScoreText();
            other.gameObject.SetActive(false);


        }
        

        
    }



}
