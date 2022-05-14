using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Araba : MonoBehaviour
{
    public WheelCollider SkyCarWheelFrontLeft, SkyCarWheelFrontRight, SkyCarWheelRearLeft, SkyCarWheelRearRight;

    public float motorhizi;
    
    void Update()
    {
        SkyCarWheelRearRight.motorTorque = motorhizi * Input.GetAxis("Vertical");
        SkyCarWheelRearLeft.motorTorque = motorhizi * Input.GetAxis("Vertical");
        
    }
}
