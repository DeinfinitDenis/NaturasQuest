using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    public SpriteRenderer buttonSprite;
    public GameObject flowerBig;
    public GameObject flowerSmall;
    public bool canInteract = false;
    public int random, counter, reward;
    void Start()
    {   
        buttonSprite.enabled = false;
        if(StaticVariables.snowPlantQuest == false){
            flowerBig.SetActive(false);
            flowerSmall.SetActive(true);
        }
        else{
            flowerBig.SetActive(true);
            flowerSmall.SetActive(false);
        }
        random = UnityEngine.Random.Range(15, 50);
        counter = 0;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && StaticVariables.snowPlantQuest == false && canInteract){
            counter++;
            if(counter >= random){
                StaticVariables.snowPlantQuest = true;
                StaticVariables.gotaCurrency += reward;
                PlayerHealth.maxHearts += 1;
                PlayerHealth.health = PlayerHealth.maxHearts;
                flowerBig.SetActive(true);
                flowerSmall.SetActive(false);
            }

        }
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Player") && StaticVariables.snowPlantQuest == false){
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
