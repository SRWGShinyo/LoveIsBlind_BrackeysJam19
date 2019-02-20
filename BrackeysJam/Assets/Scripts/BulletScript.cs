using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    
    float timeToShoot = 0f;

    float toWait = 0.5f;
    public ParticleSystem particles;
    public LayerMask whatToHit;
    public Transform bulletTrail;
    //public AudioSource scream;
    Transform firePoint;
    public HashSet<GameObject> h;

	// Use this for initialization
	void Start () {
        firePoint = transform.Find("firePoint");
        h = new HashSet<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {

        if (toWait != 0.5f)
        {
            toWait -= Time.deltaTime;
        }
        if (toWait <= 0f)
        {
            toWait = 0.5f;
            foreach (var n in h)
            {
                HoldOutline outlined = n.GetComponent<HoldOutline>();
                if (outlined)
                {
                    outlined.outlin.enabled = true;
                    outlined.disabled = false;
                }
            }
        }

            if (Input.GetButton("Fire1") && timeToShoot <= 0f)
            {
                particles.Play();
                //scream.Play();
                toWait -= Time.deltaTime;
                timeToShoot = 3f;
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
