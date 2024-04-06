using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timedSpawns : MonoBehaviour
{
    public GameObject heal;
    public GameObject explosive;
    public bool explosiveElapsed = true;
    public bool healElapsed = true;
    public static int numOfHeals = 0;

    void Start(){
        numOfHeals = 0;
    }

    void Update(){
        if(healElapsed && numOfHeals <= 5){
            StartCoroutine(healDrops());
        }

        if(explosiveElapsed){
            StartCoroutine(explosives());
        }

        if(numOfHeals < 0)
            numOfHeals = 0;
    }

    IEnumerator healDrops(){
        healElapsed = false;
        yield return new WaitForSeconds(Random.Range(5f, 10f));
        healElapsed = true;
        numOfHeals++;
        Vector2 random = new Vector2(Random.Range(-17.22f, 14f), Random.Range(7.81f, -5.47f));
        Instantiate(heal, random, Quaternion.identity);
    }

    IEnumerator explosives(){
        explosiveElapsed = false;
        yield return new WaitForSeconds(Random.Range(1f, 4f));
        explosiveElapsed = true;
        Vector2 random = new Vector2(Random.Range(-17.22f, 14f), Random.Range(7.81f, -5.47f));
        Instantiate(explosive, random, Quaternion.identity);
    }
}
