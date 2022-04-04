using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMover : MonoBehaviour
{
    [SerializeField] float roadSpeed = 20f;
    [SerializeField] float speedMultiplier = 1f;
    [SerializeField] GameObject health;
    [SerializeField] GameObject speed;
    float spawnTime;

    void SpawnSpeed()
    {
        speed.SetActive(true);
        Invoke("DisableSpeed", 30);
    }

    void DisableSpeed()
    {
        speed.SetActive(false);
    }

    void DisableHealth()
    {
        health.SetActive(false);
    }

    void SpawnHealth()
    {
        health.SetActive(true);
        Invoke("DisableHealth", 15);

    }

    /* private void Start()
    {
        Time.timeScale = 1;
    } */
    void Update()
    {
        MoveRoad();
        
    }

    void MoveRoad()
    {
        roadSpeed += Time.deltaTime * speedMultiplier; 
        transform.position += Vector3.back * Time.deltaTime * roadSpeed;
    }

    void Awake()
    {
        StartCoroutine("PowerSpawner");
    }

    IEnumerator PowerSpawner()
    {
        while (true)
        {
            SpawnHealth();
            SpawnSpeed();
            spawnTime = Random.Range(7f, 14f);

            yield return new WaitForSeconds(spawnTime);
        }
         
    }
}
