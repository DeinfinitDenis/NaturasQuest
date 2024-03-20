using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DNumero1 : MonoBehaviour
{
    public Animator playerAnim;
    void Start()
    {
        AwakeningZone.lastScene = "DungeonNumeroUno";
        StaticVariables.holeZoneMainKey = true;

        playerAnim.SetFloat("direction mem y", 1f);
        playerAnim.SetFloat("direction mem x", 0f);
    }

}
