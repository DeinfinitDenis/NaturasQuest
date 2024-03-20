using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveMidLeft : MonoBehaviour
{
    public Animator playerAnim;
    void Start()
    {
        AwakeningZone.lastScene = "CaveMiddleLeft";
        playerAnim.SetFloat("direction mem x", 0f);
        playerAnim.SetFloat("direction mem y", 1f);
    }

    
}
