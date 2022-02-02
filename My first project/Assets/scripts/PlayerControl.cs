using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 50.0f;
    private float hInput; //horizontal input
    private float fInput; //forward/backward input


    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        fInput = Input.GetAxis("Vertical");

        // makes player move forward (can be problematic)
        transform.Translate(Vector3.forward * Time.deltaTime * speed * fInput);
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * hInput);
    }
}
