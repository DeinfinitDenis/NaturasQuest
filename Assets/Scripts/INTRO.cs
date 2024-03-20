using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class INTRO : MonoBehaviour
{
    public Animator fadeAnim;
    public string nextScene;

    void Start(){
        fadeAnim.SetBool("isPressed", false);
    }

    void Update(){
        StartCoroutine(SceneLoadDelay());
        if(Input.GetKeyDown(KeyCode.E)){
            fadeAnim.SetBool("isPressed", true);
            StopAllCoroutines();
            StartCoroutine(SkipIntro());
        }
    }

    IEnumerator SceneLoadDelay(){
        yield return new WaitForSeconds(30f);
        fadeAnim.SetBool("isPressed", true);
        yield return new WaitForSeconds(0.5f);
        fadeAnim.SetBool("isPressed", false);
        SceneManager.LoadScene(nextScene);
    }
    IEnumerator SkipIntro(){
        yield return new WaitForSeconds(0.5f);
        fadeAnim.SetBool("isPressed", false);
        SceneManager.LoadScene(nextScene);
    }
}
