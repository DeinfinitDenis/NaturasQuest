using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nocturne : MonoBehaviour
{
    [SerializeField]
    private float maxHealth;

    [SerializeField]
    private int cash;

    public GameObject ending1door;
    public GameObject ending2door;
    private float health;


    private void Start()
    {
        ending1door.SetActive(true);
        ending2door.SetActive(false);
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
            StaticVariables.NocturneIsDefeated = true;
            ending1door.SetActive(false);
            ending2door.SetActive(true);
            StaticVariables.gotaCurrency += cash;
            Destroy(gameObject); 
        }
    }
}
