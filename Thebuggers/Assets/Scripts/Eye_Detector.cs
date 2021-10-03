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
        animEye.SetBool("detected", true);
        animPupil.SetBool("detected", true);
        animBackground.SetBool("detected", true);
        Destroy(background);
        Destroy(tremor);
    }
}
