using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBossScript : MonoBehaviour
{
    public Animator playerAnim;
    void Start()
    {
        playerAnim.SetFloat("direction mem x", 0f);
        playerAnim.SetFloat("direction mem y", 1f);
        AwakeningZone.lastScene = "SnowBoss";
    }
}
