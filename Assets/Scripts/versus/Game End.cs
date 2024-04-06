using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{
    public Animator fadeAnim;
    public Animator player1Win;
    public Animator player2Win;
    public GameObject bgMusic;
    //public GameObject walkingSfx;
    public AudioSource gameOverMusic;
    public bool canPlay = true;

    void Update()
    {
        if(StaticVariables.isGameOver)
            StartCoroutine(delayForGameOver());
    }

    IEnumerator delayForGameOver(){
        bgMusic.SetActive(false);
        //walkingSfx.SetActive(false);
        
        yield return new WaitForSeconds(1f);

        if(canPlay){
            gameOverMusic.Play();
            canPlay = false;
        }

        if(StaticVariables.winner == 1){
            player1Win.SetBool("isGameOver", true);
            fadeAnim.SetBool("isPressed", true);
        }
        else if(StaticVariables.winner == 2){
            player2Win.SetBool("isGameOver", true);
            fadeAnim.SetBool("isPressed", true);
        }

        yield return new WaitForSeconds(2f);

        player2Win.SetBool("isGameOver", false);
        player1Win.SetBool("isGameOver", false);
    
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("MainMenu");
    }
}
