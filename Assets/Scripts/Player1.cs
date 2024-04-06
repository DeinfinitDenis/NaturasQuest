using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    //player movement

    private Rigidbody2D mainplayer;
    public float moveHorizontal, moveVertical;
    public float speed = 10f;
    public Animator playerAnim;

    //slash skill
    public bool isSlash = false;
    public bool isArrow = false;
    public GameObject slash;

    //Bow Weapon
    public GameObject arrow;
    public float arrowSpeed = 10f;
    //other
    public static int weaponslot = 1;
    public static bool isEscape;
    public GameObject playerMenu;
    public static bool inImpulse = false;

    void Start(){
        playerAnim.SetFloat("direction mem x", 1f);
        playerAnim.SetFloat("direction mem y", 0f);
        mainplayer = gameObject.GetComponent<Rigidbody2D>();
        slash.SetActive(false);
        playerAnim.SetInteger("weaponslot", 1);
        weaponslot = 1;
        isEscape = false;
        playerMenu.SetActive(false);
    }

    
    void Update(){  
        //enter si exit menu & upgrades
        if(Input.GetKeyDown(KeyCode.Escape) && StaticVariables.isGameOver == false){
            if(isEscape){
                isEscape = false;
                playerMenu.SetActive(false);
            }
            else{
                isEscape = true;
                playerMenu.SetActive(true);
            }
        }

        //altele
        if(!playerAnim.GetBool("isAttack") && StaticVariables.isGameOver == false){
            moveHorizontal = Input.GetAxisRaw("Horizontal");
            moveVertical = Input.GetAxisRaw("Vertical");
        }

        if(StaticVariables.isGameOver){
            playerMenu.SetActive(false);
            isEscape = false;
            moveHorizontal = 0f;
            moveVertical = 0f;
        }

        playerAnim.SetFloat("X", moveHorizontal);
        playerAnim.SetFloat("Y", moveVertical);

        if(moveHorizontal == 0 && moveVertical == 0){
            playerAnim.SetBool("isMoving", false);
            playerAnim.SetBool("isIdle", true);
        }
        else{
            playerAnim.SetBool("isMoving", true);
            playerAnim.SetBool("isIdle", false);
        }

        if(playerAnim.GetBool("isMoving")){
            playerAnim.SetFloat("direction mem x", moveHorizontal);

            if(playerAnim.GetFloat("direction mem x") != 0f)
                playerAnim.SetFloat("direction mem y", 0f);
            else playerAnim.SetFloat("direction mem y", moveVertical);
        }
        
        if(Input.GetKeyDown(KeyCode.Space) && !isEscape && StaticVariables.isGameOver == false){
            if(weaponslot == 1 && !playerAnim.GetBool("isAttack")){
                playerAnim.SetBool("isAttack", true);
                if(!isSlash)
                    SlashCode();    
            }
            else if(weaponslot == 2 && !playerAnim.GetBool("isAttack")){
                playerAnim.SetBool("isAttack", true);
                if(!isArrow)
                    StartCoroutine(ArrowDelay());
            }
        }

        if(Input.GetKey(KeyCode.Alpha1)){
            weaponslot = 1;
            playerAnim.SetInteger("weaponslot", weaponslot);
        }
        else if(Input.GetKey(KeyCode.Alpha2)){
            weaponslot = 2;
            playerAnim.SetInteger("weaponslot", weaponslot);
        }

    }

    void FixedUpdate(){
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        movement.Normalize();

        if(inImpulse == true){}
        else if(!isSlash && playerAnim.GetBool("isAttack") == false){
            mainplayer.velocity = movement * speed;
            
        }
        else mainplayer.velocity = new Vector2(0f, 0f);
    }

    //Slash Skill
    void SlashCode(){
        StartCoroutine(SlashDelay());
        
        float dirx = playerAnim.GetFloat("direction mem x");
        float diry = playerAnim.GetFloat("direction mem y");

        if(dirx < 0)
            dirx += 0.3f;
        else if(dirx > 0)
            dirx -= 0.3f;

        if(diry < 0)
            diry += 0.3f;
        else if(diry > 0)
            diry -= 0.3f;

        slash.transform.position = new Vector2(mainplayer.transform.position.x + dirx, mainplayer.transform.position.y + diry);    
    }
    
    IEnumerator SlashDelay(){
        isSlash = true;
        slash.SetActive(true);
        yield return new WaitForSeconds(StaticVariables.slashDelay);
        slash.SetActive(false);
        isSlash = false;
        playerAnim.SetBool("isAttack", false);

    }

     //Arrow
    void ArrowCode(){

        float dx = playerAnim.GetFloat("direction mem x");
        float dy = playerAnim.GetFloat("direction mem y");
        float rotaux;
        
        if(dy != 0f){
            if(dy > 0f)
                rotaux = 0f;
            else rotaux = 180f;    
        }
        else rotaux = -dx * 90f;
    
        Vector2 direction = new Vector2(dx, dy);
        var harrow = Instantiate(arrow, mainplayer.transform.position, Quaternion.Euler(new Vector3(0f, 0f, rotaux)));
        harrow.GetComponent<Rigidbody2D>().velocity = direction * arrowSpeed;
        Destroy(harrow, 0.7f);

    }

    IEnumerator ArrowDelay(){
        isArrow = true;
        yield return new WaitForSeconds(0.3f);
        isArrow = false;
        playerAnim.SetBool("isAttack", false);

        ArrowCode();
    }

    IEnumerator isImpulse()
    {

        inImpulse = true;
        yield return new WaitForSeconds(0.1f);
        inImpulse = false;
    }

    public AudioSource healParticleSound;
    void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.CompareTag("HealParticle")){
            timedSpawns.numOfHeals--;
            Health1.health1++;
            healParticleSound.Play();
            Destroy(collision.gameObject);
        }
    }

}

