using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{
    public GameObject credits;
    public GameObject mainmenu;

    public float Speed;
    private Vector3 movement;
    private Vector3 newpos;

    void Start()
    {
        newpos = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector3(0f,1f,0f);
        transform.position += movement*Time.deltaTime*Speed;
        if(Input.anyKey){
            transform.position = newpos;
            credits.SetActive(false);
            mainmenu.SetActive(true);
        }
    }
}
