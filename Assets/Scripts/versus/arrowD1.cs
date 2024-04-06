using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowD1 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("VPlayer2")){
            Health2.health2--;
            Destroy(gameObject);
        }

        if(other.gameObject.CompareTag("Obstacles"))
        {
            Destroy(gameObject);
        }

    }
}
