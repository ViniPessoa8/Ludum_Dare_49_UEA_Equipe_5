using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float Speed; 
    public float JumpForce;
    private bool jumping;
    private bool dead;
    private Rigidbody2D rig;
    private Animator animator; 

    public AudioSource jumpSound;
    public AudioSource walkSound;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void LateUpdate()
    {
        Move();
        Jump();
    }

    void PlayWalkSound(){
        walkSound.Play();
    }

    void Move()
    {
        float movement = Input.GetAxis("Horizontal");
        rig.velocity = new Vector2(movement * Speed, rig.velocity.y);
        if(Input.GetAxis("Horizontal") > 0f){
            animator.SetBool("walk",true);
            transform.eulerAngles = new Vector3(0f,0f,0f);
        }
        if(Input.GetAxis("Horizontal") < 0f){
            animator.SetBool("walk",true);
            transform.eulerAngles = new Vector3(0f,180f,0f);
        }
        if(Input.GetAxis("Horizontal") == 0f){
            animator.SetBool("walk",false);
        }
    }

    void Jump()
    {
        if(Input.GetButtonDown("Jump") && jumping == false){
            rig.AddForce(new Vector2(0f,JumpForce), ForceMode2D.Impulse);
            jumpSound.Play();
        }

        if(rig.velocity.y < 0){
            animator.SetTrigger("falling");
        }
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.layer == 8){
            jumping = false;
            animator.SetBool("jump",false);
        }
    }

    void OnCollisionExit2D(Collision2D collision){
        if(collision.gameObject.layer == 8){
            jumping = true;
            animator.SetBool("jump",true);
        }
    }

    void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "Eye"){
            StartCoroutine("restartLevel");
        }
    }

    IEnumerator restartLevel(){
        animator.SetBool("dead",true);
        rig.bodyType = RigidbodyType2D.Static;
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
