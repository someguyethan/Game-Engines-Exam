using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Rigidbody2D rb;

    private void Start()
    {
        rb.velocity = new Vector2(Random.Range(-1, 1), Random.Range(-1, 1));
    }
}
