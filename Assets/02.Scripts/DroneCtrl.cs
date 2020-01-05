using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneCtrl : MonoBehaviour
{
    //Wings 
    public Transform[] wings;

    public float updownSpeed = 10.0f;   //상승,하강 속도
    public float forwardSpeed = 10.0f;  //전후진 속도
    public float rotateSpeed = 80.0f;   //회전 속도

    public Joystick leftJoyStick;   //Up/Down
    public Joystick rightJoyStick;  //전후진, 회전

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateWings();
    }

    void RotateWings()
    {
        for (int i=0; i<wings.Length; i++)
        {
            wings[i].Rotate(Vector3.up * Time.deltaTime * 2000.0f);
        }
    }
}
