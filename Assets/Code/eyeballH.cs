using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eyeballH : MonoBehaviour
{
    public AudioSource audio;
    
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "fireball")
        {
            //Debug.Log("hit");
            audio.Play();
        } else if (collision.gameObject.tag == "ceiling" || collision.gameObject.tag == "wall")
        {
            Debug.Log("hit");
        }
    }
}
