using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsMyloverSeen : MonoBehaviour {
    public GameObject arrow;
    public Renderer lover;

	// Update is called once per frame
	void Update () {
        if (lover && lover.isVisible)
        {
            arrow.SetActive(false);
        }

        else
        {
            arrow.SetActive(true);
        }
	}
}
