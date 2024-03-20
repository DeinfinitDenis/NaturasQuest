using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveSouth : MonoBehaviour
{
    public Animator playerAnim;
    void Start()
    {
        AwakeningZone.lastScene = "CaveSouth";
        playerAnim.SetFloat("direction mem x", 0f);
        playerAnim.SetFloat("direction mem y", -1f);
    }

    
}
