using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Bounce : MonoBehaviour
{
    float speed = .2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 bouncing = transform.position;
        bouncing.x = bouncing.x + speed;
        bouncing.y = bouncing.y + speed;
            transform.position = bouncing;
    }
}
