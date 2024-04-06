using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticVariables : MonoBehaviour
{
    public static bool Cave1DoorIsUnlocked = false;
    public static bool manoleQuest = false;
    public static bool EminescuQuest = false;
    public static bool SnowZoneQuestHeart = false;
    public static bool snowPlantQuest = false;
    public static bool isGameOver = false;
    public static bool canyonZoneMainKey = true;
    public static bool snowZoneMainKey = false;
    public static bool holeZoneMainKey = false;
    public static bool NocturneIsDefeated = false;
    //health
    public static bool[] Hearts = {false, false, false, false, false, false, false, false, false, false, false};

    //VERSUS
    public static int winner = 0;

    //UPGRADE SYSTEM
    public static float gotaCurrency = 0f;
    //COST
    public static float cost = 200f;
    //upgrades
    public static int sLvlDmg = 1;
    public static int bLvlDmg = 1;
    public static int sLvlSpd = 1;
    public static int bLvlSpd = 1;
    public static int healLvl = 1;
    //dmg
    public static float slashDmg = 1f;
    public static float arrowDmg = 2f;
    //SPEED
    public static float arrowSpeed = 15f;
    public static float slashDelay = 0.5f;
    //HEAL
    public static int healPts = 2;
}
