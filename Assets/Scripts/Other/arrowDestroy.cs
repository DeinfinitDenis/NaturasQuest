using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowDestroy : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Obstacles") || other.gameObject.CompareTag("Enemy") || other.gameObject.CompareTag("SnowBoss") || other.gameObject.CompareTag("Nocturne"))
        {
            Destroy(gameObject);
        }
    }
}
