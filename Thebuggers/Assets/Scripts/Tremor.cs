using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tremor : MonoBehaviour
{
    public float smoothness = 10.0f;
    public GameControl gameController;

    // Update is called once per frame
    void Update()
    {
        shake();
    }

    void shake()
    {
        float randomFactor = gameController.actualTime;
        float randomNumber = Random.Range(-randomFactor,randomFactor);
        Debug.Log(randomNumber);

        Quaternion target = Quaternion.Euler(0, 0, randomNumber);

        transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * smoothness);
    }
}
