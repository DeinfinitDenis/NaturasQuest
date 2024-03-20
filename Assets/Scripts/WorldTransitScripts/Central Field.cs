using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CentralField : MonoBehaviour
{
    public GameObject player;
    public Animator playerAnim;

    void Start()
    {
        if(AwakeningZone.lastScene == "Cave 1"){
            player.transform.position = new Vector2(7.7f, -1.9f);
            playerAnim.SetFloat("direction mem x", -1f);
            playerAnim.SetFloat("direction mem y", 0f);
        }

        else if(AwakeningZone.lastScene == "GreatTreeSite"){
            player.transform.position = new Vector2(18.08f, 51.61f);
            playerAnim.SetFloat("direction mem x", -1f);
            playerAnim.SetFloat("direction mem y", 0f);
        }

        else if(AwakeningZone.lastScene == "Castle Field"){
            player.transform.position = new Vector2(14f, 83.4f);
            playerAnim.SetFloat("direction mem x", 0f);
            playerAnim.SetFloat("direction mem y", -1f);
        }

        else if(AwakeningZone.lastScene == "CentralHeartCave"){
            player.transform.position = new Vector2(-39.74f, 39.26f);
            playerAnim.SetFloat("direction mem x", 1f);
            playerAnim.SetFloat("direction mem y", 0f);
        }

        AwakeningZone.lastScene = "Central Field";
    }

}
