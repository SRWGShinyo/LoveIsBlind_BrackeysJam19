using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGet : MonoBehaviour {

    GameObject gameman;
    GameObject lover;
    float waitAMinute = 0f;
    bool hasplayed = false;
	// Use this for initialization
	void Start () {
        gameman = GameObject.Find("GameManager");
        lover = GameObject.FindGameObjectWithTag("Lover");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (waitAMinute > 0f && hasplayed)
        {
            waitAMinute -= Time.fixedDeltaTime;
        }

        if (waitAMinute <= 0f && hasplayed)
        {
            if (SceneManager.GetActiveScene().name != "Level6")
            {
                if (lover)
                    Destroy(lover);
                gameman.GetComponent<WinningCondition>().Win();
            }
            else
            {
                if (lover)
                    Destroy(lover);
                gameman.GetComponent<WinningCondition>().WinLast();
            }
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (hasplayed)
        { }
        

        else if (collision.gameObject.tag == "Lover" && !hasplayed)
        {
            Animator animaton = collision.gameObject.GetComponent<Animator>();
            animaton.SetBool("Angry", true);
            waitAMinute = 3.4f;
            Destroy(gameObject.GetComponent<Rigidbody2D>());
            hasplayed = true;
        }

        else if (collision.gameObject.tag == "Levelbord")
        {
            Debug.Log("Reach limit of the level !");
        }

        else if (collision.gameObject.tag == "Flower")
        {
            Debug.Log("Got a flower !");
        }

        else
        {
            GameObject gameman = GameObject.Find("GameManager");
            if (gameman)
            {
                gameman.GetComponent<UIHandling>().setFlowers(0);
                gameman.GetComponent<UIHandling>().addPoints(-3000);
            }

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
