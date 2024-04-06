using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAT1 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("VPlayer2"))
        {
            Health2.health2 --;
            //if(!arrow)collision.GetComponent<EnemyHealth>().depleteHealth(damaj + StaticVariables.slashDmg * 4);
           // else collision.GetComponent<EnemyHealth>().depleteHealth(damaj + StaticVariables.arrowDmg * 2);

        }
    }
        

}
