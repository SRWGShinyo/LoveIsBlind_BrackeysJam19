using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour {

    public GameObject toInstant;
    public GameObject dropLoc;

    public float timeToSpawn = 2f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (timeToSpawn <= 0f)
        {
            timeToSpawn = 2f;
            GameObject go = Instantiate(toInstant, dropLoc.transform);
            //go.transform.position = dropLoc.transform.position;
        }

        else
        {
            timeToSpawn -= Time.fixedDeltaTime;
        }
	}
}
