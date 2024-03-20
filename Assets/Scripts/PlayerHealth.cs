using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public static int maxHearts = 5;
    public static int health = 5;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    public Image bowUI;
    public Image swordUI;
    public Image canHeal;
    public Image cannotHeal;
    public static float healCountdown;
    public bool healManage = true;
    public TextMeshProUGUI countdownHealTxt;

    void Start(){
        if(StaticVariables.snowZoneMainKey == false){
            cannotHeal.enabled = false;
            canHeal.enabled = false;
            countdownHealTxt.enabled = false;
        }
    }

    void Update()
    {   
        if(StaticVariables.snowZoneMainKey == true)
        {
            if(healCountdown > 0f){
                healCountdown -= Time.deltaTime;
                int seconds = (int)(healCountdown % 60);
                countdownHealTxt.text = seconds + " ";
            }

            else if(healCountdown <= 0f){
                cannotHeal.enabled = false;
                canHeal.enabled = true;
                healManage = true;
                countdownHealTxt.enabled = false;
            }

            if(Input.GetKeyDown(KeyCode.Space) && healManage == true && StaticVariables.isGameOver == false){
                healManage = false;
                cannotHeal.enabled = true;
                canHeal.enabled = false;
                countdownHealTxt.enabled = true;
                health += StaticVariables.healLvl + 1;
                healCountdown = 11f;
            }
        }
        
        if(health <= 0)
            StaticVariables.isGameOver = true;

        if(health > maxHearts){
            health = maxHearts;
        }

        if(PlayerActions.weaponslot == 1){
            bowUI.enabled = false;
            swordUI.enabled = true;
        }
        else if(PlayerActions.weaponslot == 2){
            bowUI.enabled = true;
            swordUI.enabled = false;
        }

        for(int i = 0; i < hearts.Length; i++){
            if(i < health)
                hearts[i].sprite = fullHeart;
            else hearts[i].sprite = emptyHeart;

            if(i < maxHearts)
                hearts[i].enabled = true;
            else hearts[i].enabled = false;
        }
    }

    public void ImpulseUwU(int UwUdamaj, Vector2 t){
        health-=UwUdamaj;
        GetComponent<Rigidbody2D>().AddForce((t - new Vector2(transform.position.x, transform.position.y)).normalized * -15f, ForceMode2D.Impulse);
    }
}
