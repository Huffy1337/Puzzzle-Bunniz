using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector2 objectPosition = transform.position;

        //Move Horizontal
        if (Input.GetButtonDown("Horizontal") && Input.GetAxisRaw("Horizontal") > 0) 
        {
            objectPosition.x = transform.position.x + 320;
            Debug.Log("Right");
        } else if (Input.GetButtonDown("Horizontal") && Input.GetAxisRaw("Horizontal") < 0) {
            Debug.Log("Left");
        }

        //Move Vertical


    }
}
