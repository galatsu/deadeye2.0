using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eyeballH : MonoBehaviour
{
    //public Sprite eyeballHit;
    //public Sprite eyeball;
    public AudioSource audio;
    //public SpriteRenderer render;
    
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "fireball")
        {
            //Debug.Log("hit");
            audio.Play();
            //render.sprite = eyeballHit;

        } else if (collision.gameObject.tag == "ceiling" || collision.gameObject.tag == "wall")
        {
            Debug.Log("hit");

        } else if (collision.gameObject.tag == "floor")
        {

        }
    }
}
