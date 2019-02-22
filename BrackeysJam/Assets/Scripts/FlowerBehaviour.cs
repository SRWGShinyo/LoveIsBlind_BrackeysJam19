using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerBehaviour : MonoBehaviour {

    public GameObject gameman;
    Animator anim;
	// Use this for initialization
	void Start () {
        gameman = GameObject.Find("GameManager");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            if (gameman.GetComponent<UIHandling>().getFlowers() < 3)
                gameman.GetComponent<UIHandling>().addToFlower();
            int flowers = gameman.GetComponent<UIHandling>().getFlowers();
            if (flowers <= 3)
            {
                anim = collision.gameObject.GetComponentInChildren<Animator>();
                anim.SetInteger("flowers", flowers);
            }
            Destroy(gameObject);
        }
    }
}
