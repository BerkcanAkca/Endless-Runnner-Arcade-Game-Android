using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDisplayer : MonoBehaviour
{
    PlayerControls hp;
    [SerializeField] GameObject[] healthBar;


    // Start is called before the first frame update
    void Start()
    {
        hp = FindObjectOfType<PlayerControls>();
        healthBar[0].SetActive(true);
        healthBar[1].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        DisplayHealth();
    }

    void DisplayHealth()
    {
        if (hp.playerHP == 3)
            healthBar[0].SetActive(true); 
        if (hp.playerHP == 2)
        {
            healthBar[0].SetActive(false);
            healthBar[1].SetActive(true);
        }
        if (hp.playerHP == 1)
            healthBar[1].SetActive(false);
    }
    
}
