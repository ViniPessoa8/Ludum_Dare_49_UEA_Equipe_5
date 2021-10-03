using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next_Level_Door : MonoBehaviour
{
    private Animator anim;
    public GameControl gameControl;
    public string next_scene;
    
    public GameObject player;
    public AudioSource openingSound;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.tag == "Player"){
            anim.SetBool("open", true);
            openingSound.Play();
            player.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            StartCoroutine("openingDoor");
        }
    }

    IEnumerator openingDoor(){
        yield return new WaitForSeconds(2.5f);
        gameControl.goToNextScene(next_scene);
    }
}
