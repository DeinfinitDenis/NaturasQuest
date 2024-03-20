using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BossAi2 : MonoBehaviour
{
    private CircleCollider2D vision;

    [SerializeField]
    private bool hasProjectiles;

    [SerializeField]
    private GameObject projectile;

    //[SerializeField]
    //private GameObject projectile1;

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

    //[SerializeField]
    //private float attackAnimationDuration = 0.2f;


    private Animator animator;

    [SerializeField]
    private float attackSpeed = 10;

    [SerializeField]
    private Vector3 pos;


    bool isShoooting = false;

    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        em = GetComponent<EnemyMovement>();
        //animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        //agent.updatePosition = false;
        //agent.updateUpAxis = false;

        StartCoroutine("Heal");
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = pos;
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
            int ability = UnityEngine.Random.Range(0, 2);
            if (ability == 0)
            {
                StartCoroutine("Shooot");
                Debug.Log("Attack");
            }
            else if (ability == 1)
            {
                StartCoroutine("Attaack");
            }
            else if (ability == 2)
            {
                StartCoroutine("MultiAttaack");
            }

        }
        //Debug.Log((transform.position - GameObject.Find("/Player").transform.position).normalized);
    }



    IEnumerator Shooot()
    {
        isShoooting = true;

        //animator.SetBool("IsShooting", true);
        //yield return new WaitForSeconds(0.20f);
        //animator.SetBool("IsShooting", false);
        GameObject proj = Instantiate(projectile, transform.position, Quaternion.identity, GameObject.Find("Summons").transform);
        proj.GetComponent<RotateToFaceProjectile>().Face();
        //if (attackDistance < 2.1) proj.GetComponent<SpriteRenderer>().enabled = false;
        if (needsVelo)
        {
            proj.GetComponent<Projectile>().velo = -((transform.position - GameObject.Find("Player").transform.position).normalized) * 8;
            proj.GetComponent<Projectile>().abcd = transform.position;
        }
        yield return new WaitForSeconds(1);
        isShoooting = false;

    }

    IEnumerator Attaack()
    {
        isShoooting = true;

        //animator.SetBool("IsShooting", true);
        //yield return new WaitForSeconds(0.20f);
        //animator.SetBool("IsShooting", false);

        for (int i = 0; i < 5; i++)
        {
            GameObject proj = Instantiate(projectile, transform.position + new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), 0), Quaternion.identity, GameObject.Find("Summons").transform);
            proj.GetComponent<RotateToFaceProjectile>().Face();
            //if (attackDistance < 2.1) proj.GetComponent<SpriteRenderer>().enabled = false;
            if (needsVelo)
            {
                proj.GetComponent<Projectile>().velo = -((proj.transform.position - GameObject.Find("Player").transform.position).normalized) * 8;
                proj.GetComponent<Projectile>().abcd = transform.position;
                yield return new WaitForSeconds(0.1f);
            }
        }
        yield return new WaitForSeconds(20 * (1 / attackSpeed));
        isShoooting = false;
    }
    /*
    IEnumerator MultiAttaack()
    {
        isShoooting = true;
        //animator.SetBool("IsShooting", true);
        //yield return new WaitForSeconds(attackAnimationDuration + 0.1f);
        //animator.SetBool("IsShooting", false);
        for (int i = 0; i < 6; i++)
        {
            Vector2 pos = new Vector2(transform.position.x + UnityEngine.Random.Range(10, -10), transform.position.y + UnityEngine.Random.Range(10, -10));
            GameObject proj = Instantiate(projectile1, pos, Quaternion.identity, GameObject.Find("Summons").transform);
            proj.transform.localScale = new Vector3(2f, 2f, 1);
            proj.GetComponent<SoulAttack>().dealsDamage = false;
            yield return new WaitForSeconds(0.5f);
        }
        isShoooting = false;

    }
    */

    IEnumerator Heal() 
    {
        PlayerHealth.health++;
        yield return new WaitForSeconds(3);
        StartCoroutine(Heal());
    }
}
