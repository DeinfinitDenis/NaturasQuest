using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Health2 : MonoBehaviour
{
    public int maxHearts = 12;
    public static int health2 = 12;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    public Image bowUI;
    public Image swordUI;

    void Start(){
     
    }

    void Update()
    {   
        if(health2 <= 0){
            StaticVariables.isGameOver = true;
            StaticVariables.winner = 2;
        }

        if(health2 > maxHearts){
            health2 = maxHearts;
        }

        if(Player2.weaponslot == 1){
            bowUI.enabled = false;
            swordUI.enabled = true;
        }
        else if(Player2.weaponslot == 2){
            bowUI.enabled = true;
            swordUI.enabled = false;
        }

        for(int i = 0; i < hearts.Length; i++){
            if(i < health2)
                hearts[i].sprite = fullHeart;
            else hearts[i].sprite = emptyHeart;

            if(i < maxHearts)
                hearts[i].enabled = true;
            else hearts[i].enabled = false;
        }
    }

    public void ImpulseUwU(int UwUdamaj){
        health2-=UwUdamaj;
    }
}
