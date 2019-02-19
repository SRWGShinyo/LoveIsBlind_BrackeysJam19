﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAccordingMouse : MonoBehaviour {

    LineRenderer line;

    private void Start()
    {
        line = gameObject.GetComponent<LineRenderer>();
        Cursor.visible = false;
    }
    // Update is called once per frame
    void Update () {
        Vector3 diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        diff.Normalize();

        float rotZ = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ);

        line.SetPosition(0, transform.position);
        line.SetPosition(1, Camera.main.ScreenToWorldPoint(Input.mousePosition));
        line.startColor = Color.red;
        line.endColor = Color.red;
	}
}
