using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookTowardsLover : MonoBehaviour {

    public GameObject lover;
    void Update()
    {
        Vector3 diff = lover.transform.position - transform.position;
        diff.Normalize();

        float rotZ = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ);
    }
}
