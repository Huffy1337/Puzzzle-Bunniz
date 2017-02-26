using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 objectPosition = transform.position;

        //Move Horizontal
        if (Input.GetButtonDown("Horizontal") && Input.GetAxisRaw("Horizontal") > 0) 
        {
            objectPosition.x = objectPosition.x + 3.20f;
            transform.position = objectPosition;
            Debug.Log("Right");

        } else if (Input.GetButtonDown("Horizontal") && Input.GetAxisRaw("Horizontal") < 0) {
            objectPosition.x = objectPosition.x - 3.20f;
            transform.position = objectPosition;
            Debug.Log("Left");
        }

        //Move Vertical
        if (Input.GetButtonDown("Vertical") && Input.GetAxisRaw("Vertical") > 0)
        {
            objectPosition.y = objectPosition.y + 3.20f;
            transform.position = objectPosition;
            Debug.Log("Up");
        }
        else if (Input.GetButtonDown("Vertical") && Input.GetAxisRaw("Vertical") < 0)
        {
            objectPosition.y = objectPosition.y - 3.20f;
            transform.position = objectPosition;
            Debug.Log("Down");
        }

    }
}
