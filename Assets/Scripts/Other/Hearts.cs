using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hearts : MonoBehaviour
{
    public SpriteRenderer buttonSprite;
    public bool canInteract = false;

    public int number;

    void Start(){
        buttonSprite.enabled = false;
        if(StaticVariables.Hearts[number] == true)
            gameObject.SetActive(false);
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.E) && canInteract && StaticVariables.Hearts[number] == false){
            if(number == 3){
                StaticVariables.SnowZoneQuestHeart = true;
            }
            StaticVariables.Hearts[number] = true;
            PlayerHealth.maxHearts++;
            PlayerHealth.health = PlayerHealth.maxHearts;
            gameObject.SetActive(false);
        }

    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Player")){
            buttonSprite.enabled = true;
            canInteract = true;
        }
    }

    void OnTriggerExit2D(Collider2D other){
        if(other.gameObject.CompareTag("Player")){
            buttonSprite.enabled = false;
            canInteract = false;
        }
    }
}
