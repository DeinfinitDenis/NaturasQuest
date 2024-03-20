using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveNorth : MonoBehaviour
{
    public Animator playerAnim;
    void Start()
    {
        AwakeningZone.lastScene = "CaveNorth";
        playerAnim.SetFloat("direction mem x", 0f);
        playerAnim.SetFloat("direction mem y", 1f);
    }

}
