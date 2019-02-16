using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.layer = 1;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerExit2D(Collider2D collision)
    {
        collision.gameObject.layer = 1;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.layer = 0;
    }



}
