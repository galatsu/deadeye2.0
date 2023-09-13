using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class eyeballH : MonoBehaviour
{
    public Sprite eyeballHit;
    public Sprite eyeball;
    public SpriteRenderer render;

    public float push = 10;
    Rigidbody2D rb;

    public AudioSource audio1;
    public AudioSource audio2;

    public string failstate;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        render = gameObject.GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "fireball")
        {
            //Debug.Log("hit");
            audio1.Play();
            render.sprite = eyeballHit;

        }
        /*else if (collision.transform.CompareTag("fireball"))
        {
            
        }*/
        else if (collision.gameObject.tag == "ceiling")
        {
            Debug.Log("hit");
            rb.AddForce(Vector2.down * push, ForceMode2D.Impulse);
            audio2.Play();

        }
        else if (collision.gameObject.tag == "wall")
        {
            rb.AddForce(Vector2.left * push, ForceMode2D.Impulse);
            audio2.Play();

        }
        else if (collision.gameObject.tag == "otherWall")
        {
            rb.AddForce(Vector2.right * push, ForceMode2D.Impulse);
            audio2.Play();
        }
        else if (collision.gameObject.tag == "floor")
        {
            SceneManager.LoadScene(failstate);
        } else
        {
            render.sprite = eyeball;
        }
    }
}
