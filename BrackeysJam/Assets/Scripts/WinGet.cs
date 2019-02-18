using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGet : MonoBehaviour {

    GameObject gameman;
	// Use this for initialization
	void Start () {
        gameman = GameObject.Find("GameManager");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Lover")
        {
            gameman.GetComponent<WinningCondition>().Win();
        }
    }
}
