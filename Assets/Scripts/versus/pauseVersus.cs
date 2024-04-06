using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pauseVersus : MonoBehaviour
{

    public Animator fadeAnim;
    public GameObject playerMenu;
    public AudioSource clickSound;

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
