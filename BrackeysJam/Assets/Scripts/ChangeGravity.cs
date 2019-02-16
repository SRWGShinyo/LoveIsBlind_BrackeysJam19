using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGravity : MonoBehaviour {

    bool isInverted;
	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Rigidbody2D>().gravityScale = 1f;
    }
	
	// Update is called once per frame
	void Update () {
       if (Input.GetKey(KeyCode.Space))
        {
            if (!isInverted)
            {
                isInverted = true;
            }
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 10, 0);
        }

        else
        {
            
            if (isInverted)
            {
                isInverted = false;
            }
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, -10, 0);
        }
	}
}
