using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    
    float timeToShoot = 0f;

    public ParticleSystem particles;
    public LayerMask whatToHit;
    public Transform bulletTrail;
    Transform firePoint;
    public HashSet<GameObject> h;

	// Use this for initialization
	void Start () {
        firePoint = transform.Find("firePoint");
        h = new HashSet<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButton("Fire1") && timeToShoot <= 0f)
        {
            particles.Play();
            foreach (var n in h)
            {
                HoldOutline outlined = n.GetComponent<HoldOutline>();
                if (outlined)
                {
                    outlined.outlin.enabled = true;
                    outlined.disabled = false;
                }
            }
            timeToShoot = 0.3f;
        }

        else
        {
            timeToShoot -= Time.deltaTime;
        }
	}


    private void OnTriggerEnter2D(Collider2D collision)
    {
        h.Add(collision.gameObject);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        h.Remove(collision.gameObject);
    }
}
