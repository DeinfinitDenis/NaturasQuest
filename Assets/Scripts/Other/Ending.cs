using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
    public Animator fadeAnim;
    public string nextScene;

    void Start(){
        fadeAnim.SetBool("isPressed", false);
        StartCoroutine(SceneLoadDelay());
    }

    IEnumerator SceneLoadDelay(){
        yield return new WaitForSeconds(15f);
        fadeAnim.SetBool("isPressed", true);
        yield return new WaitForSeconds(0.5f);
        fadeAnim.SetBool("isPressed", false);
        SceneManager.LoadScene(nextScene);
    }
}
