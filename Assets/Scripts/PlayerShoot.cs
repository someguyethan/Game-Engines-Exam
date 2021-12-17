using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;


public class PlayerShoot : MonoBehaviour
{
    public GameObject projectile;
    public float projectileSpeed;
    public float damage;
    public Transform shootPos;
    public AudioSource audio;

    ObjectPool pool;

    [DllImport("ProjectileLifespanDLL")]
    private static extern void ChangeLifespan();

    // Start is called before the first frame update
    void Start()
    {
        pool = ObjectPool.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //GameObject p = Instantiate(projectile, shootPos.position, transform.rotation);
            GameObject p = pool.SpawnFromPool("Projectile", shootPos.position, transform.rotation);
            p.GetComponent<Rigidbody2D>().velocity = transform.up * projectileSpeed;
            audio.Play();
        }
    }
}
