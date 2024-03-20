using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snowhEARt : MonoBehaviour
{
    public GameObject skull;
    public GameObject dialogue;
    void Start()
    {
        dialogue.SetActive(false);
        if(StaticVariables.canyonZoneMainKey == false){
            gameObject.SetActive(false);
            skull.SetActive(true);
        }
        else{
            gameObject.SetActive(true);
            skull.SetActive(false);
        }
    }
}
