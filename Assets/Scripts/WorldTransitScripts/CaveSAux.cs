using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CaveSAux : MonoBehaviour
{

    private string nextScene;
    void Start()
    {
        if(AwakeningZone.lastScene == "CaveHeartS"){
            nextScene = "SnowZone";
            StartCoroutine(delay());
        }
        else if(AwakeningZone.lastScene == "SnowZone"){
            nextScene = "CaveHeartS";
            StartCoroutine(delay());
        }

    }

    IEnumerator delay(){
        AwakeningZone.lastScene = "CaveHeartSAux";
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene(nextScene);
        
    }
}
