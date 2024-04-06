using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow1 : MonoBehaviour
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
        if(collision.gameObject.CompareTag("Obstacles") || collision.gameObject.CompareTag("VPlayer2"))
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "VPlayer2")
        {
            GameObject.Find("VPlayer2").GetComponent<Health2>().ImpulseUwU(1);
            GameObject.Find("VPlayer2").GetComponent<Player2>().StartCoroutine("isImpulse");
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag != "Enemy" && collision.gameObject.tag != "SnowBoss" && merge && (collision.gameObject.tag != "SwordSlash" || pariable)) Destroy(gameObject);

    }

}
