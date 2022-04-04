using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    [SerializeField] GameObject[] players;
    [SerializeField] ParticleSystem changeParticles;
    [SerializeField] AudioSource changeSound;
     int currentPlayer = 0;
    public int playerHP = 3;
    Vector3 startPos, endPos, direction;


    void Update()
    {
        TransformCube();
        //Finger touched screen
       
    }

    void TransformCube()
    {
        // PC Controls for Debug
       /*  if (Input.GetMouseButtonDown(0)) 
        {
            changeParticles.Play();
            players[currentPlayer].SetActive(false);

            currentPlayer++;
            if (currentPlayer >= players.Length)
            {
                currentPlayer = 0;
            }
            players[currentPlayer].SetActive(true);

        }

        if (Input.GetMouseButtonDown(1))
        {
            players[currentPlayer].SetActive(false);
            changeParticles.Play();

            currentPlayer--;
            if (currentPlayer < 0)
            {
                currentPlayer = players.Length - 1;
            }
            players[currentPlayer].SetActive(true);

        } */

        ///
        
           // Android Controls
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
              {
                  startPos = Input.GetTouch(0).position;
              }
              //Finger released from screen
              if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
              {
                  endPos = Input.GetTouch(0).position;
                  direction = startPos - endPos;
                  // if swipe down
                  if (direction.y > 0)
                  { 
        changeParticles.Play();
          players[currentPlayer].SetActive(false);

                  currentPlayer--;
                  if (currentPlayer < 0)
                  {
                      currentPlayer = players.Length - 1;
                  }
                  players[currentPlayer].SetActive(true);
                changeSound.Play();
          }
                      // if swipe up
                      if (direction.y < 0)
                  { 
        changeParticles.Play();
           players[currentPlayer].SetActive(false);

                  currentPlayer++;
                  if (currentPlayer >= players.Length)
                  {
                      currentPlayer = 0;
                  }
                  players[currentPlayer].SetActive(true);
                changeSound.Play();
            }
              }  


           /// 
    }



}
