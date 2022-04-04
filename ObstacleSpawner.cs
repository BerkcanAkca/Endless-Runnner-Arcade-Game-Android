using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstacles;
    
    
    Vector3 correction = new Vector3(0, 0, 3.2f);
    

   
    /* void Update()
    {
        
    } */

    public void SpawnObstacle()
    {
        // Set them all active
        for (int i = 0; i < obstacles.Length; i++)
        {
            obstacles[i].SetActive(true);
        }

        int obstacleNo = Random.Range(0, obstacles.Length);

        // Disable one
        obstacles[obstacleNo].SetActive(false);
        







        //position range is decided upon road Length
       
        for (int i = 0; i < obstacles.Length; i++)
        {
            float obstaclePosition = Random.Range(-4.5f, 4.5f);
            Vector3 spawnPositionInc = new Vector3(transform.position.x, transform.position.y, obstaclePosition);
            obstacles[i].transform.localPosition = spawnPositionInc;
        }
        
        if (Mathf.Abs(Vector3.Distance(obstacles[0].transform.localPosition, obstacles[1].transform.localPosition)) < 2f)
        {
            obstacles[0].transform.localPosition += correction;
        }
        if (Mathf.Abs(Vector3.Distance(obstacles[0].transform.localPosition, obstacles[2].transform.localPosition)) < 2f)
        {
            obstacles[0].transform.localPosition += correction;
        }
        if (Mathf.Abs(Vector3.Distance(obstacles[1].transform.localPosition, obstacles[2].transform.localPosition)) < 2f)
        {
            obstacles[1].transform.localPosition += correction;
        }

    }
}
