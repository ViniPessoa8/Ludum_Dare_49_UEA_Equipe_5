using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tremor : MonoBehaviour
{
    public float smoothyness = 10.0f;
    public GameControl gameController;

    // Update is called once per frame
    void Update()
    {
        tremer();
    }

    void tremer()
    {
        float randomFactor = gameController.actualTime;
        float randomNumber = Random.Range(-randomFactor,randomFactor);
        Debug.Log(randomNumber);

        // Rotate the cube by converting the angles into a quaternion.
        Quaternion target = Quaternion.Euler(0, 0, randomNumber);

        // Dampen towards the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * smoothyness);
    }
}
