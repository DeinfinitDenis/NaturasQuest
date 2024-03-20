using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveMidRight : MonoBehaviour
{
    public Animator playerAnim;
    void Start()
    {
        AwakeningZone.lastScene = "CaveMiddleRight";
        playerAnim.SetFloat("direction mem x", 1f);
        playerAnim.SetFloat("direction mem y", 0f);
    }

}
