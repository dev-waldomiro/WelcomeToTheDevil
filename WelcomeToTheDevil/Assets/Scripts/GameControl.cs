using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public static GameControl instance = null;
    [SerializeField]
    GameObject[] obstacles;
    [SerializeField]
    Transform spawnPoint1,spawnPoint2;
    float nextSpawn,spawnRate;

    void Start()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
        Time.timeScale = 1f;
        spawnRate = Random.Range(2, 10);
        nextSpawn = Time.time + spawnRate;
    }
    void Update()
    {
        if (Time.time > nextSpawn)
            SpawnObstacle();
        
    }
    void SpawnObstacle()
    {
        spawnRate = Random.Range(2, 7);
        nextSpawn = Time.time + spawnRate;
        int randomObstacle = Random.Range(0, obstacles.Length);
        if(randomObstacle == 0)
             Instantiate(obstacles[randomObstacle], spawnPoint1.position, Quaternion.identity);
        else 
             Instantiate(obstacles[randomObstacle], spawnPoint2.position, Quaternion.identity);

    }
}
