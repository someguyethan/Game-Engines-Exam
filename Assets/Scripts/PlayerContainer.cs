using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContainer : MonoBehaviour
{
    public int score;
    public int lives;
    public float timer = 60f;
    public Transform respawnPos;

    private void Update()
    {
        timer -= Time.deltaTime;
        if (lives == 0)
        {
            //game over
        }
        else if (timer <= 0f)
        {
            //win
        }
    }

    private void OnTriggerEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Respawn(respawnPos.position);
        }
    }

    void Respawn(Vector3 position)
    {
        transform.position = position;
        lives--;
    }
}
