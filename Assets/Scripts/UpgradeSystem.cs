using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpgradeSystem : MonoBehaviour
{
    public TextMeshProUGUI sLvlDmgT;
    public TextMeshProUGUI bLvlDmgT;
    public TextMeshProUGUI sLvlSpdT;
    public TextMeshProUGUI bLvlSpdT;
    public TextMeshProUGUI healLvlT;
    public TextMeshProUGUI costT;
    public TextMeshProUGUI gotaCount;
    public AudioSource clickSound;
    public float costIndex = 150f;

    void Update()
    {
        gotaCount.text =" : " + StaticVariables.gotaCurrency;
        sLvlDmgT.text = StaticVariables.sLvlDmg + " /10";
        bLvlDmgT.text = StaticVariables.bLvlDmg + " /10";
        sLvlSpdT.text = StaticVariables.sLvlSpd + " /10";
        bLvlSpdT.text = StaticVariables.bLvlSpd + " /10";
        healLvlT.text = StaticVariables.healLvl + " / 5";
        costT.text = "Upgrade Cost: " + StaticVariables.cost;
    }

    public void Sword_DMG(){
        if(StaticVariables.sLvlDmg < 10 && StaticVariables.gotaCurrency >= StaticVariables.cost){
            StaticVariables.sLvlDmg++;
            StaticVariables.slashDmg += 0.5f;
            StaticVariables.gotaCurrency -= StaticVariables.cost;
            StaticVariables.cost += costIndex;
            clickSound.Play();
        }
    }

    public void Bow_DMG(){
        if(StaticVariables.bLvlDmg < 10 && StaticVariables.gotaCurrency >= StaticVariables.cost){
            StaticVariables.bLvlDmg++;
            StaticVariables.arrowDmg += 0.5f;
            StaticVariables.gotaCurrency -= StaticVariables.cost;
            StaticVariables.cost += costIndex;
            clickSound.Play();
        }
    }

    public void Sword_SPEED(){
        if(StaticVariables.sLvlSpd < 10 && StaticVariables.gotaCurrency >= StaticVariables.cost){
            StaticVariables.sLvlSpd++;
            StaticVariables.slashDelay -= 0.02f;
            StaticVariables.gotaCurrency -= StaticVariables.cost;
            StaticVariables.cost += costIndex;
            clickSound.Play();
        }
    }

    public void Bow_SPEED(){
        if(StaticVariables.bLvlSpd < 10 && StaticVariables.gotaCurrency >= StaticVariables.cost){
            StaticVariables.bLvlSpd++;
            StaticVariables.arrowSpeed += 1f;
            StaticVariables.gotaCurrency -= StaticVariables.cost;
            StaticVariables.cost += costIndex;
            clickSound.Play();
        }
    }

    public void HEAL(){
        if(StaticVariables.healLvl < 5 && StaticVariables.gotaCurrency >= StaticVariables.cost){
            StaticVariables.healLvl++;
            StaticVariables.slashDmg += 1;
            StaticVariables.gotaCurrency -= StaticVariables.cost;
            StaticVariables.cost += costIndex;
            clickSound.Play();
        }
    }
}
