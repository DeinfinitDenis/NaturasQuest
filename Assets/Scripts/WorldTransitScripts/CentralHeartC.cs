using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CentralHeartC : MonoBehaviour
{
    public GameObject player;
    public Animator playerAnim;

    void Start()
    {
        if(AwakeningZone.lastScene == "SnowZone"){
            player.transform.position = new Vector2(-0.93f, 0.1f);
            playerAnim.SetFloat("direction mem y", 0f);
            playerAnim.SetFloat("direction mem x", 1f);
        }

        if(AwakeningZone.lastScene == "Central Field"){
            player.transform.position = new Vector2(38.14f, -67.09f);
            playerAnim.SetFloat("direction mem x", -1f);
            playerAnim.SetFloat("direction mem y", 0f);
        }

        AwakeningZone.lastScene = "CentralHeartCave";
    }

}
