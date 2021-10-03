using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eye_Detector : MonoBehaviour
{
    public Animator animEye;
    public Animator animPupil;
    public Animator animBackground;
    public GameObject background;
    public Tremor tremor;
    public GameObject backgroundNoise;

    public AudioSource eyeDetecting;

    void Start()
    {

    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.tag == "Player"){
            Detect();
        }
    }

    public void Detect(){
        eyeDetecting.Play();
        animEye.SetBool("detected", true);
        animPupil.SetBool("detected", true);
        animBackground.SetBool("detected", true);
        Destroy(background);
        Destroy(tremor);
        Destroy(backgroundNoise);
    }
}
