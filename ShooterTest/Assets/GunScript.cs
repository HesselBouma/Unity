
using UnityEngine;

public class GunScript : MonoBehaviour{

    public float damage = 10f;
    public float range = 100f;
    public GameObject ImpactEffect;

    public Camera fpsCam;
    public ParticleSystem MuzzleFlash;

    void Update(){

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();

        }
        
    }

    void Shoot ()
    {
        MuzzleFlash.Play();
        RaycastHit hit;
       if( Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(fpsCam.transform.position);

            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);

            }
            {
                Object impactGO = Instantiate(ImpactEffect, hit.point, Quaternion .LookRotation(hit.normal));
                Destroy(impactGO, 2f);
            }
        }

    }

}
