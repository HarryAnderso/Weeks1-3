using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    //float speed = .2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mousePos;
        //Vector2 pos = transform.position;
        //pos.x = Input.mousePosition.x;
        //pos.y = Input.mousePosition.y;
        //transform.position = pos;
    }
}
