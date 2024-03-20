using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holeDungeonEntrance : MonoBehaviour
{
    public GameObject entrance;
    public GameObject dialogue;
    void Start()
    {
        if(StaticVariables.snowZoneMainKey == false){
            dialogue.SetActive(true);
            entrance.SetActive(false);
        }
        else{
            dialogue.SetActive(false);
            entrance.SetActive(true);
        }
    }
}
