using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveLR : MonoBehaviour
{
    //coached by Lucy in this one!
    public float playerSpeed = 1f;
    Animator myAnim;

    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = transform.position;

        if(Input.GetKey(KeyCode.A))
        {
            newPos.x -= playerSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            newPos.x += playerSpeed * Time.deltaTime;
        }

        transform.position = newPos;

        if (newPos.x > 0 || newPos.x < 0)
        {
            myAnim.SetBool("isWalking", true);

            if (newPos.x > 0)
            {
                myAnim.SetBool("isWalkingForward", true);
            }
            else
            {
                myAnim.SetBool("isWalkingForward", false);
            }
            if (newPos.x < 0)
            {
                myAnim.SetBool("isWalkingBackwards", true);
            }
            else
            {
                myAnim.SetBool("isWalkingBackwards", false);
            }
        }
        else
        {
            myAnim.SetBool("isWalking", false);
        }

    }
}
