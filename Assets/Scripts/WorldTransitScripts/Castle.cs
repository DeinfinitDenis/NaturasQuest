using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Castle : MonoBehaviour
{
    public GameObject dialogue;
    public GameObject unlocked;
    public GameObject aux;
    void Start()
    {
        aux.SetActive(false);
        if(StaticVariables.canyonZoneMainKey == true && StaticVariables.snowZoneMainKey == true && StaticVariables.holeZoneMainKey == true){
            unlocked.SetActive(true);
            dialogue.SetActive(false);
        }
        else{
            unlocked.SetActive(false);
            dialogue.SetActive(true);
        }

    }

}
