using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMove : MonoBehaviour {

    float speed = 10f;
    public Animator animaton;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        animaton.SetFloat("Direction", Input.GetAxis("Horizontal"));

        float DirX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.position = new Vector2(transform.position.x + DirX, transform.position.y);
	}
}
