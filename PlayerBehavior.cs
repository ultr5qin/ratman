using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public float speed;
    public float rotateSpeed = 5f;
    public float walkSpeed = 10f;
    public float runSpeed = 50f;
    public bool isRunning = false;



    private float vInput;
    private float hInput;




    void Update()
    {
        vInput = Input.GetAxis("Vertical") * speed;
        hInput = Input.GetAxis("Horizontal") * rotateSpeed;

        this.transform.Translate(Vector3.forward * vInput * Time.deltaTime);
        this.transform.Rotate(Vector3.up * hInput * Time.deltaTime);


        if(Input.GetKey(KeyCode.LeftShift))
        {
            isRunning = true;
            speed = runSpeed;

        }
        else
        {
            isRunning = false;
            speed = walkSpeed;
        }    
    }
}
