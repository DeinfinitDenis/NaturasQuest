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
        AwakeningZone.lastScene = "MainMenu";
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

    IEnumerator SceneLoadDelay(){
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Intro");
    }

    IEnumerator QuitDelay(){
        yield return new WaitForSeconds(0.5f);
        Application.Quit();
    }
}
