using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantQuest : MonoBehaviour
{
    public SpriteRenderer buttonSprite;
    public SpriteRenderer exclamation;
    public GameObject dialogue1;
    public GameObject dialogue2;
    public bool canInteract = false;
    
    void Start(){
        if(StaticVariables.snowPlantQuest == true)
            exclamation.enabled = false;
        buttonSprite.enabled = false;
        dialogue1.SetActive(false);
        dialogue2.SetActive(false);
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.E) && canInteract && (dialogue1.activeSelf == false && dialogue2.activeSelf == false)){
            
            if(StaticVariables.snowPlantQuest == false){
                dialogue1.SetActive(true);
                dialogue2.SetActive(false);
            }
            else{
                exclamation.enabled = false;
                dialogue1.SetActive(false);
                dialogue2.SetActive(true);
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


