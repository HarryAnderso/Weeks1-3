using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    public float rotationspeed;//rotation speed determines how fast the planet turns, and how fast its satalites orbit
    public AnimationCurve curve;//sets up the animation curve, which can speed up or slow down the rotaiton, as seen on the moon of the green planet
    public float t;//time varible
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        
        t += Time.deltaTime;//makes the t float increase with time natrually
        if(t>1)//resets t value once it goes beyond 1
        { t = 0; }
        transform.eulerAngles += new Vector3(0, 0, (rotationspeed*curve.Evaluate(t)))*Time.deltaTime;//rotates the object around on the z axis, child objects of stars will always keep themselves a set distance from the parent star, and this in turn rotates them due to position inheritance
        //because they think their parent is the origen of the world, they always think they are a set distance away from it, so no math is required to change the x/y positon values
    }

}
