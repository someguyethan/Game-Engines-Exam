using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContainer : MonoBehaviour
{
    public int health;

    /*private void OnCollisionEnter2D(Collision collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            Destroy(this.gameObject);
            collision.gameObject.SetActive(false);
        }
        else if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
        }
    }*/
}
