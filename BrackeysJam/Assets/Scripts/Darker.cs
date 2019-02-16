using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Darker : MonoBehaviour {

	// Use this for initialization
	void Start () {
        RenderSettings.ambientSkyColor = Color.black;
        RenderSettings.ambientLight = Color.black;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
