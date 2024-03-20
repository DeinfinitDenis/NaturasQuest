using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanyonZone : MonoBehaviour
{
    public GameObject player;
    public Animator playerAnim;
    void Start()
    {
        if(AwakeningZone.lastScene == "Castle Field"){
            player.transform.position = new Vector2(-7.04f, 0.37f);
            playerAnim.SetFloat("direction mem y", 0f);
            playerAnim.SetFloat("direction mem x", 1f);
        }
        else if(AwakeningZone.lastScene == "CaveSouth"){
            player.transform.position = new Vector2(127.58f, -24.5f);
            playerAnim.SetFloat("direction mem y", 1f);
            playerAnim.SetFloat("direction mem x", 0f);
        }
        else if(AwakeningZone.lastScene == "CaveMiddleRight"){
            player.transform.position = new Vector2(172.94f, 19.02f);
            playerAnim.SetFloat("direction mem y", 0f);
            playerAnim.SetFloat("direction mem x", -1f);
        }
        else if(AwakeningZone.lastScene == "CaveNorth"){
            player.transform.position = new Vector2(156.49f, 82.49f);
            playerAnim.SetFloat("direction mem y", -1f);
            playerAnim.SetFloat("direction mem x", 0f);
        }
        else if(AwakeningZone.lastScene == "CaveMiddleLeft"){
            player.transform.position = new Vector2(63.51f, 49.41f);
            playerAnim.SetFloat("direction mem y", -1f);
            playerAnim.SetFloat("direction mem x", 0f);
        }
        else if(AwakeningZone.lastScene == "DungeonNumeroDuo"){
            player.transform.position = new Vector2(227f, 5.23f);
            playerAnim.SetFloat("direction mem y", -1f);
            playerAnim.SetFloat("direction mem x", 0f);
        }
        else if(AwakeningZone.lastScene == "CanyonAux1"){
            player.transform.position = new Vector2(17.5f, 20.37f);
            playerAnim.SetFloat("direction mem y", -1f);
            playerAnim.SetFloat("direction mem x", 0f);
        }
        else if(AwakeningZone.lastScene == "CanyonAux2"){
            player.transform.position = new Vector2(17.56f, 42.01f);
            playerAnim.SetFloat("direction mem y", 1f);
            playerAnim.SetFloat("direction mem x", 0f);
        }
        AwakeningZone.lastScene = "CanyonZone";
    }

}
