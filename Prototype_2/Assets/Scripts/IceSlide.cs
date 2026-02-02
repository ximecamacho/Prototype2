using UnityEngine;
using System.Collections;

public class IceSlide : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float speed = 10;
    //float jumpSpeed = 8; 
    float friction = 1;
    private Vector3 curVel = Vector3.zero;
    //private float velY = 0; 
    private CharacterController controller;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Input.GetAxis("Horizontal"), 0, 0);

        if (!controller) controller = GetComponent<CharacterController>();
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Vector3 vel = transform.TransformDirection(direction) * speed;
        curVel = Vector3.Lerp(curVel, vel, 0.5f * friction * friction * Time.deltaTime);
        controller.Move(curVel * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "IceFloor") friction = 0.1f;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "IceFloor") friction = 1;
    }

    //void FixedUpdate()
    //{
    //    //GetComponent<Rigidbody2D>().linearVelocity = Vector2.ClampMagnitude(GetComponent<Rigidbody2D>().linearVelocity, maxVelocity);
    //}
}
