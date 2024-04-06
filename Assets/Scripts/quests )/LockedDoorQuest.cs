using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoorQuest : MonoBehaviour
{
    public SpriteRenderer buttonSprite;
    public SpriteRenderer exclamation;
    public GameObject dialogue1;
    public GameObject dialogue2;
    public float questCost;
    public bool canInteract = false;
    public static bool questStarted = false;
    
    void Start(){
        if(StaticVariables.Cave1DoorIsUnlocked == true)
            exclamation.enabled = false;
        buttonSprite.enabled = false;
        dialogue1.SetActive(false);
        dialogue2.SetActive(false);
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.E) && canInteract && (dialogue1.activeSelf == false && dialogue2.activeSelf == false)){
            
            if(StaticVariables.gotaCurrency >= questCost && StaticVariables.Cave1DoorIsUnlocked == false && questStarted == true){
                exclamation.enabled = false;
                StaticVariables.gotaCurrency -= questCost;
                StaticVariables.Cave1DoorIsUnlocked = true;
                dialogue2.SetActive(true);
                dialogue1.SetActive(false);
            }
            else if(StaticVariables.Cave1DoorIsUnlocked == true){
                dialogue1.SetActive(false);
                dialogue2.SetActive(true);
            }
            else{
                dialogue1.SetActive(true);
                dialogue2.SetActive(false);
            }
            
            questStarted = true;
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


