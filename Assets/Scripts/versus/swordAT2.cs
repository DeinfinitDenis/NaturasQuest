using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAT2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("VPlayer1"))
        {
            Health1.health1 --;
            //if(!arrow)collision.GetComponent<EnemyHealth>().depleteHealth(damaj + StaticVariables.slashDmg * 4);
           // else collision.GetComponent<EnemyHealth>().depleteHealth(damaj + StaticVariables.arrowDmg * 2);

        }
    }
        

}
