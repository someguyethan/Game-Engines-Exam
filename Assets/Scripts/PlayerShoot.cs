using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject projectile;
    public float projectileSpeed;
    public float damage;
    public Transform shootPos;

    ObjectPool pool;

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
        }
    }
}
