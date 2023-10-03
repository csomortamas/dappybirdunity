using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -30;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position += Vector3.left * 5 * Time.deltaTime;


        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
            Debug.Log("Pipe deleted");
        }
    }
}
