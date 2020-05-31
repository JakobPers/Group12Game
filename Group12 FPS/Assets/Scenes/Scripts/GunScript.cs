
using UnityEngine;

public class GunScript : MonoBehaviour
{

    public float damage = 10f;
    public float range = 100f;

    public float fireRate = 0.005f;

    public Camera fpsCam;
    public ParticleSystem muzzleFlash;
    public AudioSource GunAudio;

    private float nextTimeToFire = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f/fireRate;
            Shoot();
        }
    }

    void Shoot()
    {
        muzzleFlash.Play();
        GunAudio.Play();

        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            Vector3 impact = hit.normal;

            MonsterShot monsterShot = hit.transform.GetComponent<MonsterShot>();
            if (monsterShot != null)
            {
                
                monsterShot.TakeDamage(damage);
            }
        }
    }
}
