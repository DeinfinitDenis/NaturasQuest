using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Vector2 velo { set; private get; }
    public int damage = 1;
    public Vector2 abcd;
    [SerializeField]
    private bool pariable = true;
    Rigidbody2D rb;

    bool merge = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = velo;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject.Find("Player").GetComponent<PlayerHealth>().ImpulseUwU(damage, abcd);
            GameObject.Find("Player").GetComponent<PlayerActions>().StartCoroutine("isImpulse");
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag != "Enemy" && collision.gameObject.tag != "SnowBoss" && merge && (collision.gameObject.tag != "SwordSlash" || pariable)) Destroy(gameObject);

    }

}
