using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds_Player : MonoBehaviour
{
    public Player player;
    public List<GameObject> allEyes = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.tag == "Player"){
            foreach (GameObject eye in allEyes){
                eye.GetComponent<Eye_Detector>().Detect();
            }
            player.StartCoroutine("restartLevel");
        }
    }
}
