using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosives : MonoBehaviour
{

    [SerializeField]
    private GameObject expro;

    public bool dealsDamage;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("attack");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator attack() 
    {
        GetComponent<CircleCollider2D>().enabled = false;
        yield return new WaitForSeconds(1);
        GetComponent<CircleCollider2D>().enabled = true;
        Instantiate(expro, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "VPlayer1") Health1.health1-=2;
        if (collision.tag == "VPlayer2") Health2.health2-=2;
    }
}
