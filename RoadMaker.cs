using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMaker : MonoBehaviour
{
   ScoreBoard scoreBoard;
    [SerializeField] int scorePerRoad = 3;
    [SerializeField] AudioSource spawnAudio;


    private void Start()
    {
        scoreBoard = FindObjectOfType<ScoreBoard>();
    }

    public void OnTriggerEnter(Collider other)
    {
        //120 is the value calculated from road length
        transform.parent.position += new Vector3 (0, 0, 120);
        GetComponentInParent<ObstacleSpawner>().SpawnObstacle();
        scoreBoard.IncreaseScore(scorePerRoad);
        spawnAudio.Play();
    }
}
