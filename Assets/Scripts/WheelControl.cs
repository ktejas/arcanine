using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelControl : MonoBehaviour {

    WheelJoint2D wheelJoint;

	// Use this for initialization
	void Start () {
        wheelJoint = GetComponent<WheelJoint2D>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void IncreaseSpeed()
    {
        JointMotor2D motor = wheelJoint.motor;
        motor.motorSpeed = 2000;
        wheelJoint.motor = motor;
    }
}
