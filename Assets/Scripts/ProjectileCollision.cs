using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileCollision : MonoBehaviour
{
    public PlayerContainer pc;
    private void Start()
    {
        pc = GameObject.Find("Player").GetComponent<PlayerContainer>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            gameObject.SetActive(false);
            pc.score += 100;
        }
    }
}
