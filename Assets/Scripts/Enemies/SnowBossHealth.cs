using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBossHealth : MonoBehaviour
{
    [SerializeField]
    private float maxHealth;

    [SerializeField]
    private int cash;

    
    private float health;


    private void Start()
    {
        health = maxHealth;
        if(SnowQuest.questFinished == true)
            Destroy(gameObject);
    }

    public void depleteHealth(float amount) 
    {
        health -= amount;
    }

    private void Update()
    {
        if (health <= 0) 
        {
            SnowQuest.questFinished = true;
            StaticVariables.gotaCurrency += cash;
            Destroy(gameObject); 
        }
    }
}
