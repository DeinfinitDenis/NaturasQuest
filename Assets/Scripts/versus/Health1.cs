using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Health1 : MonoBehaviour
{
    public int maxHearts = 12;
    public static int health1 = 12;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    public Image bowUI;
    public Image swordUI;

    void Start(){
     
    }

    void Update()
    {   

        if(health1 <= 0){
            StaticVariables.isGameOver = true;
            StaticVariables.winner = 1;
        }

        if(health1 > maxHearts){
            health1 = maxHearts;
        }

        if(Player1.weaponslot == 1){
            bowUI.enabled = false;
            swordUI.enabled = true;
        }
        else if(Player1.weaponslot == 2){
            bowUI.enabled = true;
            swordUI.enabled = false;
        }

        for(int i = 0; i < hearts.Length; i++){
            if(i < health1)
                hearts[i].sprite = fullHeart;
            else hearts[i].sprite = emptyHeart;

            if(i < maxHearts)
                hearts[i].enabled = true;
            else hearts[i].enabled = false;
        }
    }

    public void ImpulseUwU(int UwUdamaj){
        health1-=UwUdamaj;
    }


}
