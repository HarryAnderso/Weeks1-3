using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Twinkle : MonoBehaviour
{
    public AnimationCurve curve2;
    //public Vector2 start; leftovers from when I was testing and needed the variables to be public for ease of accsess
    //public Vector2 end;
    [Range(0,1)]//sets the range of t to be between 0 and 1, this was needed for testing as well.I thought I should leave it in to show my process
    public float t;//time
    // Start is called before the first frame update
    //the reason its called twinkle(copy) was because of a bug that wouldnt let visual studio recognize new scripts, so i had to make copies and put them in a pre-existing folder, otherwise I couldnt commit the changes
    void Start()
    {
        //makes the starts twinkle in and out of light as you rapidly drag the mouse across the screen
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 scale = transform.localScale;//so we can manipulate the scale without interaction direclty with the scale vector 
        scale = Camera.main.ScreenToWorldPoint(Input.mousePosition);//gets the mouse position, converts it and sets scale to it
        
        Vector2 scale2 = transform.localScale;//changes the localscale to scale, which is the mouse position, which has been lerped
        scale2.x = (Mathf.Lerp(0,1f, curve2.Evaluate(scale.x)));//curves the scale so its within the range
        transform.localScale = scale2;//changes the localscale to scale, which is the mouse position, which has been interpolated to be between 0 and 1
        //the reason I only made them scale on the x axis was so I could get that old timey movie effect(think of its a wonderfull life) where when they had paintings of space, they would have rotating lights to show distant starts
    }
}
