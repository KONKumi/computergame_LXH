using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner: MonoBehaviour
{
    public GameObject enemy;
    float randX;
    float randY;
    //Zombie location that spawn randomly
    float xWidth;
    float yHeight;

    Vector2 wheretoSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;
    static int maxEnemy = 4;
    static float enemyCount = 0;

    // Update is called once per frame
    void Update()
    {
        if(enemyCount<maxEnemy)
        {
            if(Time.time>nextSpawn)
            {
                nextSpawn = Time.time + spawnRate;
                xWidth = (Screen.width - 32) / 100;
                yHeight = (Screen.width - 32) / 100;

                randX = Random.Range(-xWidth, xWidth);
                randY = Random.Range(-yHeight, yHeight);
                wheretoSpawn = new Vector2(randX, randY);
                Instantiate(enemy, wheretoSpawn, Quaternion.identity);
                enemyCount++;

            }
        }
    }
}
