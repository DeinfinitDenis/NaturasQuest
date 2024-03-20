using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public bool dealsDamage = true;
    [SerializeField]
    private int damaj = 1;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("boom");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator boom() 
    {
        yield return new WaitForSeconds(0.2f);
        GetComponent<CircleCollider2D>().enabled = false;
        yield return new WaitForSeconds(0.8f);
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && dealsDamage) 
        {
            GameObject.Find("Player").GetComponent<PlayerHealth>().ImpulseUwU(damaj, transform.position);
            StartCoroutine(isImpulse());
        }
    }

    IEnumerator isImpulse(){
        PlayerActions.inImpulse = true;
        yield return new WaitForSeconds(0.2f);
        PlayerActions.inImpulse = false;
        Destroy(gameObject);
    }
}
