using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ScreenBounds : MonoBehaviour
{
    //private CircleCollider2D body; 
    private Transform bodyTransform; 

    private Vector2 screenBounds;
    private float objectWidth;
    private float objectHeight;

    private void Awake()
    {
        //body = GetComponentInChildren<CircleCollider2D>(); 
        bodyTransform = transform.Find("Body"); 
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        objectWidth = bodyTransform.GetComponent<SpriteRenderer>().bounds.size.x / 2;
        objectHeight = bodyTransform.GetComponent<SpriteRenderer>().bounds.size.y / 2;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x * -1 + objectWidth, screenBounds.x - objectWidth);
        //viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x + objectWidth, screenBounds.x * -1 - objectWidth);
        //viewPos.y = Mathf.Clamp(viewPos.y, screenBounds.y + objectHeight, screenBounds.y * -1 - objectHeight);
        viewPos.y = Mathf.Clamp(viewPos.y, screenBounds.y * -1 - objectHeight, screenBounds.y + objectHeight);
        transform.position = viewPos;
    }
}
