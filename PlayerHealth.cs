using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] GameObject deathScreen;
    PlayerControls controls;
    [SerializeField] AudioSource speedSound;
    [SerializeField] AudioSource healthSound;
    [SerializeField] AudioSource healthLostSound;

    private void Start()
    {
        controls = FindObjectOfType<PlayerControls>();
    }


    private void OnTriggerEnter(Collider other)
    {

        
        if (other.tag == "Obstacle")
        {
            gameObject.GetComponentInParent<PlayerControls>().playerHP--;
            healthLostSound.Play();
            
        }

        if (other.tag == "Health" && gameObject.GetComponentInParent<PlayerControls>().playerHP != 3)
        {
            healthSound.Play();
            gameObject.GetComponentInParent<PlayerControls>().playerHP++;
            
        }

        if (other.tag == "Speed")
        {
            speedSound.Play();
            Time.timeScale = 0.5f;
            Invoke("ReturnNormal", 5f);
            
        }


    }
    private void Update()
    {
       
        HandleDeath();
    }
    void HandleDeath()
    {
        if (gameObject.GetComponentInParent<PlayerControls>().playerHP <= 0)
        {
            gameObject.GetComponentInParent<PlayerControls>().playerHP = 0;
            Time.timeScale = 0;
            deathScreen.SetActive(true);
            controls.enabled = false;

        }
    }

     void  ReturnNormal()
    {
        Time.timeScale = 1;
    }
}
