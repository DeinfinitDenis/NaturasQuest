using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowD2 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("VPlayer1")){
            Health1.health1--;
            Destroy(gameObject);
        }

        if(other.gameObject.CompareTag("Obstacles"))
        {
            Destroy(gameObject);
        }

    }
}
