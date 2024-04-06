using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class copac : MonoBehaviour
{
    public SpriteRenderer buttonSprite;
    public GameObject dialogue;
    public Animator copach;
    public static bool localIf;
    public bool canInteract = false;
    
    void Start(){
        if(localIf){
            copach.SetBool("isEminescu", true);
        }
        else copach.SetBool("isEminescu", false);

        buttonSprite.enabled = false;
        dialogue.SetActive(false);
    }

    void Update(){
            if(Input.GetKeyDown(KeyCode.E) && canInteract && dialogue.activeSelf == false){
                
                copach.SetBool("isEminescu", true);
                localIf = true;
                dialogue.SetActive(true);
                
            }
            else if(!canInteract || (Input.GetKeyDown(KeyCode.E) && dialogue.activeSelf == true))
                dialogue.SetActive(false);
        
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Player") && StaticVariables.EminescuQuest){
            buttonSprite.enabled = true;
            canInteract = true;
        }
    }

    void OnTriggerExit2D(Collider2D other){
        if(other.gameObject.CompareTag("Player") && StaticVariables.EminescuQuest){
            buttonSprite.enabled = false;
            //canInteract = false;
        }
    }
}
