using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDrop : MonoBehaviour {

    public float ttd = 9f;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void FixedUpdate() {
        if (ttd <= 0f)
        {
            Destroy(gameObject);
        }

        ttd -= Time.fixedDeltaTime;
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
