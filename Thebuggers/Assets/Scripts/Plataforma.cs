using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BoxState
{
    None,
    Shaking,
    Falling,
    Finished
}

public class Plataforma : MonoBehaviour
{
    [SerializeField] float fallSpeed = 3f;
    [SerializeField] Transform target;
    
    Rigidbody2D rigidbody;
    BoxCollider2D boxCollider;

    private Vector3 originalPosition;
    private Vector3 targetPosition;
    private float timer;

    public float smoothyness = 10.0f;
    public BoxState boxState { get; private set; } = BoxState.None;
    public GameControl gameController;

    // Start is called before the first frame update
    void Start()
    {
           
    }

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

    void cair()
    {
        transform.position = Vector2.MoveTowards ( transform.position, targetPosition, fallSpeed * Time.deltaTime );
        if ( ( transform.position - targetPosition ).sqrMagnitude < Vector3.kEpsilon )
        {
            transform.position = targetPosition;
            gameObject.layer = LayerMask.NameToLayer ( "Ground" );
            boxCollider.enabled = true;
            boxState = BoxState.Finished;
        }
    }
}
