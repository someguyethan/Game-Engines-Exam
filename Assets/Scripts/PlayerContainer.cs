using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerContainer : MonoBehaviour
{
    public int score;
    public int lives;
    public float timer = 60f;
    public Transform respawnPos;
    public Text scoreT;
    public Text livesT;
    public Text timerT;

    private void Start()
    {
        scoreT.text = "Score: " + score;
        livesT.text = "Lives: " + lives;
        timerT.text = "Time: " + timer;
    }
    private void Update()
    {
        timer -= Time.deltaTime;
        timerT.text = "Time: " + timer;
        scoreT.text = "Score: " + score;

        if (lives == 0)
        {
            //game over
        }
        else if (timer <= 0f)
        {
            //win
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (Time.timeScale == 0)
                Time.timeScale = 1;
            else if (Time.timeScale == 1)
                Time.timeScale = 0;
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
        livesT.text = "Lives: " + lives;
    }
}
