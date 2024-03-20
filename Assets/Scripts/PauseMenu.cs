using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{

    public Animator fadeAnim;
    public GameObject playerMenu;
    public GameObject infoTemplate;
    public bool isInfo;
    public AudioSource clickSound;

    void Start(){
        isInfo = false;
        infoTemplate.SetActive(false);
    }

    public void InfoButton(){
        
        if(isInfo){
            isInfo = false;
            infoTemplate.SetActive(false);
        }
        else{
            isInfo = true;
            infoTemplate.SetActive(true);
        }
        clickSound.Play();
    }

    public void ContinueButton(){
        PlayerActions.isEscape = false;
        playerMenu.SetActive(false);
        clickSound.Play();
    }

    public void MainMenuButton(){
        fadeAnim.SetBool("isPressed", true);
        StartCoroutine(SceneLoadDelay());
        clickSound.Play();
    }

    IEnumerator SceneLoadDelay(){
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("MainMenu");
    } 
}
