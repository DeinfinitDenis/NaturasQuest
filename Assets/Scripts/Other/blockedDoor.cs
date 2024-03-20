using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockedDoor : MonoBehaviour
{
    public GameObject blocked;
    public GameObject goodToGo;
    public GameObject dialogue;
    void Start()
    {   
        goodToGo.SetActive(false);
        blocked.SetActive(false);
        dialogue.SetActive(false);
        if(StaticVariables.canyonZoneMainKey == false){
            blocked.SetActive(true);
            goodToGo.SetActive(false);
        }
        else{
            blocked.SetActive(false);
            goodToGo.SetActive(true);
        }
    }

}
