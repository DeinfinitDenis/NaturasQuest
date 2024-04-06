using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowQuest : MonoBehaviour
{
    public SpriteRenderer buttonSprite;
    public SpriteRenderer exclamation;
    public GameObject dialogue1;
    public GameObject dialogue2;
    public GameObject heart;
    public bool canInteract = false;
    public static bool questFinished = false;
    void Start(){
        heart.SetActive(false);
        if(questFinished == true && StaticVariables.SnowZoneQuestHeart == false){
            exclamation.enabled = false;
            heart.SetActive(true);
        }
        if(StaticVariables.SnowZoneQuestHeart == true){
            heart.SetActive(false);
            exclamation.enabled = false;
        }
        buttonSprite.enabled = false;
        dialogue1.SetActive(false);
        dialogue2.SetActive(false);
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.E) && canInteract && (dialogue1.activeSelf == false && dialogue2.activeSelf == false)){
            
            if(questFinished == true){
                exclamation.enabled = false;
                dialogue2.SetActive(true);
                dialogue1.SetActive(false);
                StaticVariables.snowZoneMainKey = true;
            }
            else if(questFinished == false){
                dialogue1.SetActive(true);
                dialogue2.SetActive(false);
            }
            else{
                dialogue1.SetActive(true);
                dialogue2.SetActive(false);
            }
            
        }

        else if(!canInteract || (Input.GetKeyDown(KeyCode.E) && (dialogue1.activeSelf == true || dialogue2.activeSelf == true))){
            dialogue1.SetActive(false);
            dialogue2.SetActive(false);
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



