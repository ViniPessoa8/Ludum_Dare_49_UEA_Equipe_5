using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonCamera : MonoBehaviour
{
    public int X_movement;

    void Start()
    {
   
    }
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.tag == "Player"){
            Debug.Log("AAAa");
            transform.position = new Vector3(transform.position.x+X_movement,transform.position.y, transform.position.z);
        }
    }
}
