using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Range(0f,1f)]
    float currentSpeed = 1f;
    float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * currentSpeed * Time.deltaTime); 
    }
    private void SetMovementSpeed (float speed)
    {
        currentSpeed = speed;
    }
}
