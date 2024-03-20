using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanyonAux1 : MonoBehaviour
{
    private string nextScene;
    void Start()
    {
        if(AwakeningZone.lastScene == "CanyonZone"){
            nextScene = "CanyonAux2";
            StartCoroutine(delay());
        }
        else if(AwakeningZone.lastScene == "CanyonAux2"){
            nextScene = "CanyonZone";
            StartCoroutine(delay());
        }

    }

    IEnumerator delay(){
        AwakeningZone.lastScene = "CanyonAux1";
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene(nextScene);
        
    }
}

