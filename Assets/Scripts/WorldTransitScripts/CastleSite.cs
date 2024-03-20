using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastleSite : MonoBehaviour
{   
    public Animator playerAnim;
    public GameObject player;
    
    void Start()
    {
        if(AwakeningZone.lastScene == "Central Field"){
            player.transform.position = new Vector2(0f, 0f);
            playerAnim.SetFloat("direction mem x", 0f);
            playerAnim.SetFloat("direction mem y", 1f);
        }

        else if(AwakeningZone.lastScene == "SnowZone"){
            player.transform.position = new Vector2(-58f, 20.33f);
            playerAnim.SetFloat("direction mem x", 1f);
            playerAnim.SetFloat("direction mem y", 0f);
        }

        else if(AwakeningZone.lastScene == "CanyonZone"){
            player.transform.position = new Vector2(40.27f, 49.6f);
            playerAnim.SetFloat("direction mem x", -1f);
            playerAnim.SetFloat("direction mem y", 0f);
        }
        else if(AwakeningZone.lastScene == "Village"){}
        else if(AwakeningZone.lastScene == "Other"){}

         AwakeningZone.lastScene = "Castle Field";
    }
    
}