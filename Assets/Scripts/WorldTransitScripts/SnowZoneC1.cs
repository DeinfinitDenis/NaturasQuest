using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowZoneC1 : MonoBehaviour
{
    public Animator playerAnim;
    void Start()
    {
        AwakeningZone.lastScene = "SnowCave1";
        playerAnim.SetFloat("direction mem x", 0f);
        playerAnim.SetFloat("direction mem y", -1f);
    }

}
