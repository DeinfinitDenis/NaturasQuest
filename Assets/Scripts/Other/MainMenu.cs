using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Animator fadeAnim;
    public Renderer bgRenderer; 
    public float speed = 5f;
    public AudioSource clickSound;

    void Start()
    {
        Health1.health1 = 12;
        Health2.health2 = 12;
        AwakeningZone.lastScene = "MainMenu";
        StaticVariables.winner = 0;
        StaticVariables.isGameOver = false;
    }
    
    void Update()
    {
        bgRenderer.material.mainTextureOffset += new Vector2(Time.deltaTime * speed, 0f);
    }

    public void QuitButton(){
        fadeAnim.SetBool("isPressed", true);
        clickSound.Play();
        StartCoroutine(QuitDelay());
    }

    public void StartButton(){
        fadeAnim.SetBool("isPressed", true);
        clickSound.Play();
        StartCoroutine(SceneLoadDelay());
    }

    public void VersusButton(){
        fadeAnim.SetBool("isPressed", true);
        clickSound.Play();
        StartCoroutine(SceneLoadDelayVersus());
    }
    
    IEnumerator SceneLoadDelay(){
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Intro");
    }

    IEnumerator SceneLoadDelayVersus(){
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Versus");
    }

    IEnumerator QuitDelay(){
        yield return new WaitForSeconds(0.5f);
        Application.Quit();
    }
}
