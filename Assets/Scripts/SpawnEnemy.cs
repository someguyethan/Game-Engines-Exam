using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemy;
    public float timer = 1;

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1)
        {
            Vector3 pos = new Vector3(Random.Range(-2, 2), Random.Range(-2, 2), Random.Range(-2, 2));

            Instantiate(enemy, pos, Quaternion.identity);
            timer = 0;
        }
    }
}
