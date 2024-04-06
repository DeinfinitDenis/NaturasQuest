using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeningZone : MonoBehaviour
{
    public GameObject player;
    public Animator playerAnim;
    public static string lastScene;
    void Start()
    {
        if(lastScene == "Cave 1"){
            player.transform.position = new Vector2(2.5f, 48.3f);
            playerAnim.SetFloat("direction mem y", -1f);
            playerAnim.SetFloat("direction mem x", 0f);
        }
        else{
            playerAnim.SetFloat("direction mem y", 1f);
            playerAnim.SetFloat("direction mem x", 0f);
        }

        if(lastScene == "MainMenu"){
            StaticVariables.Cave1DoorIsUnlocked = false;
            StaticVariables.isGameOver = false;
            StaticVariables.gotaCurrency = 0;
            StaticVariables.cost = 300f;
            StaticVariables.sLvlDmg = 1;
            StaticVariables.bLvlDmg = 1;
            StaticVariables.sLvlSpd = 1;
            StaticVariables.bLvlSpd = 1;
            StaticVariables.healLvl = 1;
            StaticVariables.slashDmg = 1f;
            StaticVariables.arrowDmg = 2f;
            StaticVariables.arrowSpeed = 15f;
            StaticVariables.slashDelay = 0.5f;
            StaticVariables.healPts = 2;
            PlayerHealth.maxHearts = 5;
            PlayerHealth.health = 5;
            PlayerHealth.healCountdown = 0f;
            StaticVariables.SnowZoneQuestHeart = false;
            StaticVariables.snowPlantQuest = false;
            StaticVariables.canyonZoneMainKey = false;
            StaticVariables.snowZoneMainKey = false;
            StaticVariables.holeZoneMainKey = false;
            StaticVariables.NocturneIsDefeated = false;
            StaticVariables.EminescuQuest = false;
            StaticVariables.manoleQuest = false;
            copac.localIf = false;
            
            for(int i = 0; i<=10; i++)
                StaticVariables.Hearts[i] = false;

            LockedDoorQuest.questStarted = false;
            StaticVariables.Cave1DoorIsUnlocked = false;
            SnowQuest.questFinished = false;
        }
        lastScene = "AwakeningSite";
    }

}
