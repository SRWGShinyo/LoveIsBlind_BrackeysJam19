using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    
    float timeToShoot = 0f;

    float keepDetecting = 0f;
    float toWait = 4f;
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

        if (keepDetecting > 0f)
        {
            keepDetecting -= Time.deltaTime;
            foreach (var n in h)
            {
                HoldOutline outlined = null;
                if (n)
                    outlined = n.GetComponent<HoldOutline>();
                if (outlined)
                {
                    outlined.outlin.enabled = true;
                    outlined.disabled = false;
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.E) && timeToShoot <= 0f)
        {
           keepDetecting = 3.5f;
           particles.Play();
           toWait -= Time.deltaTime;
           timeToShoot = 3f;
        }

        timeToShoot -= Time.deltaTime;
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
