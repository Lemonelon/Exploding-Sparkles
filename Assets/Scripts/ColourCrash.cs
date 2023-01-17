using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class ColourCrash : MonoBehaviour

{
    SpriteRenderer sr;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter(Collision collision)
    {//whenever we hit something
        sr.color = new Color(2, 0, 0);//set this object's red color to 200 percent
    }

    void Update()
    {
        //linear interpolation brings two values closer together proportional to a given third value(time)
        sr.color = Color.Lerp(sr.color, Color.white, Time.deltaTime / 0.1f);//slowly linear interpolate. takes about 3 seconds to return to white
    }
}