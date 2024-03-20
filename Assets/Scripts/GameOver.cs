using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Animator fadeAnim;
    public Animator gameOverAnim;
    public GameObject bgMusic;
    public GameObject walkingSfx;
    public AudioSource gameOverMusic;
    public bool canPlay = true;

    void Update()
    {
        if(StaticVariables.isGameOver)
            StartCoroutine(delayForGameOver());

    }

    IEnumerator delayForGameOver(){
        bgMusic.SetActive(false);
        walkingSfx.SetActive(false);
        
        yield return new WaitForSeconds(1f);

        if(canPlay){
            gameOverMusic.Play();
            canPlay = false;
        }

        gameOverAnim.SetBool("isGameOver", true);
        fadeAnim.SetBool("isPressed", true);

        yield return new WaitForSeconds(2f);

        gameOverAnim.SetBool("isGameOver", false);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("MainMenu");
    }
}
