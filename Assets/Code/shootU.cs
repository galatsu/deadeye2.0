using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootU : MonoBehaviour
{
    public GameObject fireball;
    public Transform fireballSpawn;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Instantiate(fireball, fireballSpawn.position, fireballSpawn.rotation);
        }
    }
}
