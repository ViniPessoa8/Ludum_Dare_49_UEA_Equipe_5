using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eye_Detector : MonoBehaviour
{
    public Animator animEye;
    public Animator animPupil;

    void Start()
    {

    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.tag == "Player"){
            animEye.SetBool("detected", true);
            animPupil.SetBool("detected", true);
        }
    }
}
