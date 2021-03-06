using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    Rigidbody RB;

    GameObject Cam;
    public AudioClip clip;

    public AudioClip audio1;
    public AudioClip c;



    public float MoveSpeed = 10;
    public float JumpForce = 1000;


    public float MouseSensitivity = 100;

    float Vertical;
    float Horizontal;

    public float MouseX;
    public float MouseY;

    public bool IsGrounded;

    float CamRotX;


    public float MaxRotX;



    void Awake()
    {
        RB = GetComponent<Rigidbody>();
        Cam = transform.Find("Camera").gameObject;
    }





    void Update()
    {
        Vertical = Input.GetAxis("Vertical");
        Horizontal = Input.GetAxis("Horizontal");
        MouseX = Input.GetAxis("Mouse X");
        MouseY = Input.GetAxis("Mouse Y");

        RB.MovePosition((transform.position + (transform.forward) * Vertical * MoveSpeed) + (transform.right) * Horizontal * MoveSpeed);
        if (IsGrounded == true && Input.GetKeyUp(KeyCode.Space))
        {
            RB.AddForce(transform.up * JumpForce);
            AudioSource.PlayClipAtPoint(clip, transform.position);
        }

        RB.MoveRotation(RB.rotation * Quaternion.Euler(new Vector3(0, MouseX * MouseSensitivity, 0)));


        CamRotX -= MouseY * MouseSensitivity;
        CamRotX = Mathf.Clamp(CamRotX, -MaxRotX, MaxRotX);
        Quaternion CamRot = Quaternion.Euler(CamRotX, 0, 0);
        Cam.transform.localRotation = CamRot;

        

        if (IsGrounded == true && (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S)))
        {
            AudioSource.PlayClipAtPoint(audio1, transform.position);
        }


    }

    

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            IsGrounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            IsGrounded = false;
        }
    }



       




}
