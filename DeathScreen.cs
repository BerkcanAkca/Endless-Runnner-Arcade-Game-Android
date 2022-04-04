using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;


public class DeathScreen : MonoBehaviour
{
    [SerializeField] GameObject deathScreen;
    
    
    public void RestartGame()
    {
        
        deathScreen.SetActive(false);  
        SceneManager.LoadScene(0);
        

    }
    public void QuitGame()
    {
        Application.Quit();
    }

    private void Start()
    {
        
        

    }
}
