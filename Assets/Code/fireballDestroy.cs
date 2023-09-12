using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireballDestroy : MonoBehaviour
{
    void OnCollisionEnter2D (Collision2D collision) { 

        if (collision.gameObject.tag == "eyeball" || collision.gameObject.tag == "ceiling")
        {
            Debug.Log("hit");
            Destroy(gameObject);
        }
    }
}
