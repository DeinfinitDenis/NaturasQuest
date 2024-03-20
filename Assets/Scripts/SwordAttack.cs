using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    [SerializeField]
    private float damaj = 20;

    [SerializeField]
    private bool arrow = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            if(!arrow)collision.GetComponent<EnemyHealth>().depleteHealth(damaj + StaticVariables.slashDmg * 4);
            else collision.GetComponent<EnemyHealth>().depleteHealth(damaj + StaticVariables.arrowDmg * 2);

            //Debug.Log(damaj + StaticVariables.slashDmg * 4);
        }
        else if (collision.CompareTag("SnowBoss"))
        {
            if(!arrow)collision.GetComponent<SnowBossHealth>().depleteHealth(damaj + StaticVariables.slashDmg * 4);
            else collision.GetComponent<SnowBossHealth>().depleteHealth(damaj + StaticVariables.arrowDmg * 2);

            //Debug.Log(damaj + StaticVariables.slashDmg * 4);
        }
        else if (collision.CompareTag("Nocturne"))
        {
            if(!arrow)collision.GetComponent<Nocturne>().depleteHealth(damaj + StaticVariables.slashDmg * 4);
            else collision.GetComponent<Nocturne>().depleteHealth(damaj + StaticVariables.arrowDmg * 2);

            //Debug.Log(damaj + StaticVariables.slashDmg * 4);
        }
    }
}
