using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    
    float timeToShoot = 0f;

    public LayerMask whatToHit;
    public Transform bulletTrail;
    Transform firePoint;

	// Use this for initialization
	void Start () {
        firePoint = transform.Find("firePoint");
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButton("Fire1") && timeToShoot <= 0f)
        {
            Shoot();
            timeToShoot = 0.3f;
        }

        else
        {
            timeToShoot -= Time.deltaTime;
        }
	}

    void Shoot()
    {
        Vector2 mousePos = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,
            Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        Vector2 firePos = new Vector2(firePoint.position.x, firePoint.position.y);
        RaycastHit2D hit = Physics2D.Raycast(firePos, mousePos - firePos, 200, whatToHit);
        Effect();
        if (hit.collider != null)
        {
            HoldOutline outlined = hit.collider.gameObject.GetComponent<HoldOutline>();
            if (outlined)
            {
                outlined.outlin.enabled = true;
                outlined.disabled = false;
            }
            Debug.Log(hit.collider.gameObject.name);
        } 

    }

    void Effect()
    {
        Instantiate(bulletTrail, firePoint.position, firePoint.rotation);
    }
}
