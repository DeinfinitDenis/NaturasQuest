using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gaina : MonoBehaviour
{

    private Animator animator;

    [SerializeField]
    private GameObject exp;

    [SerializeField]
    private float spawnProtection;

    private bool canAttack = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine("startul");
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(GameObject.Find("Player").transform.position, transform.position) < 1 && canAttack)
        {

            StartCoroutine("boom");
            

        }
    }

    IEnumerator startul() 
    { 
        yield return new WaitForSeconds(spawnProtection);
        canAttack = true;
    }

    IEnumerator boom() 
    {
        animator.SetBool("Explode", true);
        yield return new WaitForSeconds(0.5f);
        Instantiate(exp, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
