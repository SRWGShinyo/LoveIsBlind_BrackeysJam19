using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGet : MonoBehaviour {

    GameObject gameman;
	// Use this for initialization
	void Start () {
        gameman = GameObject.Find("GameManager");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Lover")
        {
            gameman.GetComponent<WinningCondition>().Win();
        }

        else if (collision.gameObject.tag == "Levelbord")
        {
            Debug.Log("Reach limit of the level !");
        }

        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
