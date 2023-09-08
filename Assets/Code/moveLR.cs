using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveLR : MonoBehaviour
{

    public float playerSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
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
    }
}
