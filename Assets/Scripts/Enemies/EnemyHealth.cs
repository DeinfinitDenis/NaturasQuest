using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField]
    private float maxHealth;

    [SerializeField]
    private int cash;

    
    private float health;


    private void Start()
    {
        health = maxHealth;
    }

    public void depleteHealth(float amount) 
    {
        health -= amount;
    }

    private void Update()
    {
        if (health <= 0) 
        {
            StaticVariables.gotaCurrency += cash;
            Destroy(gameObject); 
        }
    }
}
