using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldOutline : MonoBehaviour {

    public SpriteRenderer outlin;
    public bool disabled;
    float tTW = 5f;

	// Use this for initialization
	void Start () {
        outlin.enabled = false;
        disabled = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (!disabled)
        {
            tTW -= Time.deltaTime;
            if (tTW <= 0f)
            {
                tTW = 5f;
                disabled = true;
                outlin.enabled = false;
            }
        }
	}
}
