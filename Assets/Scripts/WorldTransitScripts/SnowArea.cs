using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowArea : MonoBehaviour
{
    public GameObject player;
    public Animator playerAnim;

    void Start()
    {
        if(AwakeningZone.lastScene == "Castle Field"){
            player.transform.position = new Vector2(7.8f, -0.67f);
            playerAnim.SetFloat("direction mem x", -1f);
            playerAnim.SetFloat("direction mem y", 0f);
        }

        else if(AwakeningZone.lastScene == "SnowCave1"){
            player.transform.position = new Vector2(-3.46f, -9.46f);
            playerAnim.SetFloat("direction mem x", 0f);
            playerAnim.SetFloat("direction mem y", 1f);
        }

        else if(AwakeningZone.lastScene == "CentralHeartCave"){
            player.transform.position = new Vector2(-25.32f, -36.92f);
            playerAnim.SetFloat("direction mem x", -1f);
            playerAnim.SetFloat("direction mem y", 0f);
        }

        else if(AwakeningZone.lastScene == "SnowHouse"){
            player.transform.position = new Vector2(-45.46f, 15.81f);
            playerAnim.SetFloat("direction mem x", 0f);
            playerAnim.SetFloat("direction mem y", -1f);
        }

        else if(AwakeningZone.lastScene == "SnowBoss"){
            player.transform.position = new Vector2(-78.52f, 48.18f);
            playerAnim.SetFloat("direction mem x", 0f);
            playerAnim.SetFloat("direction mem y", -1f);
        }

        else if(AwakeningZone.lastScene == "CaveHeartS"){
            player.transform.position = new Vector2(-93.47f, -1.74f);
            playerAnim.SetFloat("direction mem x", 0f);
            playerAnim.SetFloat("direction mem y", -1f);
        }

        else if(AwakeningZone.lastScene == "CaveHeartSAux"){
            player.transform.position = new Vector2(-107.48f, -12.65f);
            playerAnim.SetFloat("direction mem x", 0f);
            playerAnim.SetFloat("direction mem y", -1f);
        }

        AwakeningZone.lastScene = "SnowZone";
    }

}

