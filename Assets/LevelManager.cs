using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public static LevelManager instance;

    public Rigidbody2D trapDoorRB;
    public HingeJoint2D myTrapDoor;


	// Use this for initialization
	void Start ()
    {

        instance = this;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OpenTrapDoor()
    {

        JointMotor2D myJointMotor = myTrapDoor.motor;
        myJointMotor.motorSpeed = 100;
        myTrapDoor.motor = myJointMotor;
        trapDoorRB.bodyType = RigidbodyType2D.Dynamic;


    }



}
