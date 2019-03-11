using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{

    public float damage = 10f;
    public float range = 100f;

    public Camera fpsCam;
    public GameObject impact;
    public Vector3 position;
    public AudioClip shot;
    private GameObject bullet;

    private void Start()
    {
        this.gameObject.AddComponent<AudioSource>();
        this.GetComponent<AudioSource>().clip = shot;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
            this.GetComponent<AudioSource>().Play();
        }
    }

    public void Shoot()
    {
        RaycastHit hit;

        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            //Debug.Log(hit.transform.name);
            Zombie tar = hit.transform.GetComponent<Zombie>();

            if (tar != null)
            {
                tar.Damage(damage);
                //hit.rigidbody.AddForce(-hit.normal * hitForce);
                //hit.rigidbody.AddForce(hit.transform.forward * hitForce);
            }
            GameObject bullet = Instantiate(impact, hit.point, Quaternion.LookRotation(hit.normal)); ;
            Destroy(bullet,1.5f);
        }
    }

    

}
