using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveHeartS : MonoBehaviour
{
    public Animator playerAnim;
    public GameObject player;
    void Start()
    {
        playerAnim.SetFloat("direction mem y", 1f);
        playerAnim.SetFloat("direction mem x", 0f);
        
        if(AwakeningZone.lastScene == "CaveHeartSAux"){
            player.transform.position = new Vector2(0.52f, -0.58f);
        }
        else if(AwakeningZone.lastScene == "SnowZone"){
            player.transform.position = new Vector2(120.52f, 3.53f);
        }


        AwakeningZone.lastScene = "CaveHeartS";
    }

}
