using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public GameObject goBikeShadow;

    private Rigidbody2D playerRigidbody;

	void Start ()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();

    }
	
	void FixedUpdate ()
    {
        //Move Shadow
        //goBikeShadow.transform.rotation = Quaternion.identity;

        //Input

    }
}
