using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartSnowMainS : MonoBehaviour
{
    void Update(){
        if(Input.GetKeyDown(KeyCode.E))
            StaticVariables.SnowZoneQuestHeart = true;
    }
}
