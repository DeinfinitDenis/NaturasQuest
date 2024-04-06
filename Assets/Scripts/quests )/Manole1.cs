using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manole1 : MonoBehaviour
{

    public GameObject manole1;
    public GameObject dialogue1;
    public bool canInteract = false;
    public static bool questStarted = false;
    
    void Start(){
        if(questStarted){
            manole1.SetActive(false);
        }

    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.E) && canInteract){
            questStarted = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Player")){
            canInteract = true;
        }
    }

    void OnTriggerExit2D(Collider2D other){
        if(other.gameObject.CompareTag("Player")){
            canInteract = false;
        }
    }
}


