using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eye_Detector : MonoBehaviour
{


    void Start()
    {

    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.tag == "Player"){
            Debug.Log("Player");
        }
    }
}
