using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Darker : MonoBehaviour {

    public SpriteRenderer sprite_;
	// Use this for initialization
	void Start () {
        RenderSettings.ambientSkyColor = Color.black;
        RenderSettings.ambientLight = Color.black;
        sprite_.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            sprite_.enabled = true;
        }

        else
        {
            sprite_.enabled = false;
        }
	}
}
