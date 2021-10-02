using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eye : MonoBehaviour
{
    private GameObject player;
    public float MoveSpeed;
    private Rigidbody2D rig;
    private Vector2 movement;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        rig = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Tracker();
    }

    private void FixedUpdate(){
        MovePupil(movement);
    }

    void Tracker(){
        Vector3 direction = player.transform.position - transform.position;
        movement = direction;
    }

    void MovePupil(Vector2 direction){
        rig.MovePosition((Vector2)transform.position + (direction*MoveSpeed*Time.deltaTime));
    }

    void OnTriggerEnter2D(Collider2D col){
        Debug.Log("trigger");
        if(col.gameObject.tag == "Player"){
            Debug.Log("Player");
        }
    }
}
