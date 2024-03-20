using NavMeshPlus.Extensions;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyAI : MonoBehaviour
{
    private CircleCollider2D vision;

    [SerializeField]
    private bool hasProjectiles;

    [SerializeField]
    private GameObject projectile;

    private EnemyMovement em;

    [SerializeField]
    private float movementSpeed;
    [SerializeField]
    private float stopDistance;

    [SerializeField]
    private float chaseDistance;

    [SerializeField]
    private bool needsVelo;

    [SerializeField]
    private float attackDistance = 4;

    [SerializeField]
    private bool hasWalkAnimation;

    [SerializeField]
    private float attackAnimationDuration = 0.2f;


    private Animator animator;

    [SerializeField]
    private float attackSpeed = 10;


    bool isShoooting = false;

    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        em = GetComponent<EnemyMovement>();
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        //agent.updatePosition = false;
        //agent.updateUpAxis = false;


    }

    // Update is called once per frame
    void Update()
    {
        agent.speed = movementSpeed;
        agent.stoppingDistance = stopDistance;
        transform.rotation = new Quaternion(0, 0, 0, 0);
        agent.SetDestination(transform.position);
        if (Vector2.Distance(GameObject.Find("Player").transform.position, transform.position) < chaseDistance)
        {


            agent.SetDestination(GameObject.Find("Player").transform.position);

        }

        if (Vector2.Distance(GameObject.Find("Player").transform.position, transform.position) < attackDistance && !isShoooting && hasProjectiles)
        {
            StartCoroutine("Shooot");

        }
        //Debug.Log((transform.position - GameObject.Find("/Player").transform.position).normalized);
    }


    IEnumerator Shooot()
    {
        isShoooting = true;
        animator.SetBool("IsShooting", true);
        yield return new WaitForSeconds(0.20f);
        animator.SetBool("IsShooting", false);
        GameObject proj = Instantiate(projectile, transform.position - new Vector3(0, 0.343f, 0), Quaternion.identity, GameObject.Find("Summons").transform);
        //if (attackDistance < 2.1) proj.GetComponent<SpriteRenderer>().enabled = false;
        if(needsVelo){
            proj.GetComponent<Projectile>().velo = -((transform.position - GameObject.Find("Player").transform.position).normalized) * 8;
            proj.GetComponent<Projectile>().abcd = transform.position;
        }
        yield return new WaitForSeconds(20 * (1 / attackSpeed));
        isShoooting = false;

    }
    IEnumerator Attaack()
    {
        isShoooting = true;
        animator.SetBool("IsShooting", true);
        yield return new WaitForSeconds(attackAnimationDuration+0.1f);
        animator.SetBool("IsShooting", false);
        GameObject proj = Instantiate(projectile, transform.position - new Vector3(0, 0.343f, 0), Quaternion.identity, GameObject.Find("Summons").transform);
        if (needsVelo)
        {
            proj.GetComponent<Projectile>().velo = -((transform.position - GameObject.Find("Player").transform.position).normalized) * 8;
            proj.GetComponent<Projectile>().abcd = transform.position;
        }
        yield return new WaitForSeconds(20 * (1 / attackSpeed));
        isShoooting = false;

    }
}
