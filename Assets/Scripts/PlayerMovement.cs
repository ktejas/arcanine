using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public GameObject goBikeShadow;

	void Start ()
    {
        
	}
	
	void Update ()
    {
        goBikeShadow.transform.rotation = Quaternion.identity;
    }
}
