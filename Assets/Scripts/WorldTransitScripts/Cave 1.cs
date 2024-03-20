using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cave1 : MonoBehaviour
{
    public GameObject player;
    public Animator playerAnim;

    void Start()
    {
        if(AwakeningZone.lastScene == "AwakeningSite"){
            player.transform.position = new Vector2(0.5f, -1f);
            playerAnim.SetFloat("direction mem y", 1f);
            playerAnim.SetFloat("direction mem x", 0f);
        }

        else if(AwakeningZone.lastScene == "Central Field"){
            player.transform.position = new Vector2(-13.7f, 63f);
            playerAnim.SetFloat("direction mem x", 1f);
            playerAnim.SetFloat("direction mem y", 0f);
        }

        else if(AwakeningZone.lastScene == "Cave1Cell"){
            player.transform.position = new Vector2(-0.5f, 34.5f);
            playerAnim.SetFloat("direction mem y", -1f);
            playerAnim.SetFloat("direction mem x", 0f);
        }

        else if(AwakeningZone.lastScene == "DungeonNumeroUno"){
            player.transform.position = new Vector2(23.5f, 23f);
            playerAnim.SetFloat("direction mem y", 0f);
            playerAnim.SetFloat("direction mem x", -1f);
        }

        AwakeningZone.lastScene = "Cave 1";
    }

}
