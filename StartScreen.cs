using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StartScreen : MonoBehaviour
{
    PlayerControls controls;
    
   

    private void Start()
    {
        Time.timeScale = 0;
        gameObject.SetActive(true);
        controls = FindObjectOfType<PlayerControls>();
        controls.enabled = false;
        
       
    }
    public void StartGame()
    {
        Time.timeScale = 1;
        gameObject.SetActive(false);
        controls.enabled = true;
    }
}
