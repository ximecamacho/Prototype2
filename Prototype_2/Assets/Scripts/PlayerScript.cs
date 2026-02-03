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
    public GameObject loseTextObject;

    public GameObject hatObject;
    public GameObject noseObject;
    public GameObject scarfObject;

    public GameObject arm1;
    public GameObject arm2;
    
      public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;

    public GameObject loseImage;

    public GameObject head;
    public GameObject body;

    public GameObject winImage;
    public bool do_I_Start = false;

    public int hatCount = 1;
    public int noseCount = 1;

    public int scarfCount = 2;
    public int armsCount = 2;
    public int buttonsCount = 4;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 1f;
        hatCount = 1;
        noseCount = 1;
        scarfCount = 2;
        armsCount = 2;
        buttonsCount = 4;
        SetScoreText();
        winTextObject.SetActive(false);
        loseTextObject.SetActive(false);
        hatObject.SetActive(false);
        noseObject.SetActive(false);
        scarfObject.SetActive(false);
        arm1.SetActive(false);
        arm2.SetActive(false);
        button1.SetActive(false);
        button2.SetActive(false);
        button3.SetActive(false);
        button4.SetActive(false);
        loseImage.SetActive(false);
       



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
            //loseImage.SetActive(true);
            this.gameObject.SetActive(false);
            other.gameObject.SetActive(false);
            head.SetActive(false);
            body.SetActive(false);
            do_I_Start = true;
            loseTextObject.SetActive(true);
            
            
            
         



        }
        else if (other.gameObject.CompareTag("Arms"))
        {
            if (armsCount > 0)
            {
                if (armsCount == 1)
                {
                    arm1.SetActive(true);
                }
                else
                {
                    arm2.SetActive(true);
                }
                armsCount = armsCount - 1;
            }
            SetScoreText();
            other.gameObject.SetActive(false);


        }
        else if (other.gameObject.CompareTag("Scarfs"))
        {
            if (scarfCount > 0)
            {
                scarfObject.SetActive(true);
                scarfCount = scarfCount - 1;
            }
            SetScoreText();
            other.gameObject.SetActive(false);


        }
        else if (other.gameObject.CompareTag("Hat"))
        {
            if (hatCount > 0)
            {
                hatObject.SetActive(true);

                hatCount = hatCount - 1;
            }
            SetScoreText();
            other.gameObject.SetActive(false);


        }
        else if (other.gameObject.CompareTag("Nose"))
        {
            if (noseCount > 0)
            {
                noseObject.SetActive(true);

                noseCount = noseCount - 1;
            }
            SetScoreText();
            other.gameObject.SetActive(false);


        }
        else if (other.gameObject.CompareTag("Button"))
        {
            if (buttonsCount > 0)
            {
                if (buttonsCount == 1)
                {
                    button1.SetActive(true);
                }
                else if (buttonsCount == 2)
                {
                    button2.SetActive(true);

                }
                else if (buttonsCount == 3)
                {
                    button3.SetActive(true);

                }
                else
                {
                    button4.SetActive(true);

                }




                buttonsCount = buttonsCount - 1;
            }
            SetScoreText();
            other.gameObject.SetActive(false);


        }
        

        
    }



}
