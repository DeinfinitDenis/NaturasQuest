using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanyonAux2 : MonoBehaviour
{
    private string nextScene;
    void Start()
    {
        if(AwakeningZone.lastScene == "CanyonZone"){
            nextScene = "CanyonAux1";
            StartCoroutine(delay());
        }
        else if(AwakeningZone.lastScene == "CanyonAux1"){
            nextScene = "CanyonZone";
            StartCoroutine(delay());
        }

    }

    IEnumerator delay(){
        AwakeningZone.lastScene = "CanyonAux2";
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene(nextScene);
        
    }
}

