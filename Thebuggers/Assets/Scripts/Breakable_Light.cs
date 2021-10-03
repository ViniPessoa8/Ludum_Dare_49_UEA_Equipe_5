using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable_Light : MonoBehaviour
{
    public GameObject light;
    public AudioSource breakingBulb;
    private Animator anim;
    private bool broken;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.tag == "Player"){
            anim.SetBool("broken", true);
            if(broken == false){
                breakingBulb.Play();
            }
            Destroy(light);
            broken = true;
        }
    }
}
