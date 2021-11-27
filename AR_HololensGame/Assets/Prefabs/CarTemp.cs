using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarTemp : MonoBehaviour
{
    public float speed = 20f;

    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("i"))
        {
            pos.z += speed * Time.deltaTime;
        }
        if (Input.GetKey("k"))
        {
            pos.z -= speed * Time.deltaTime;
        }
        if (Input.GetKey("l"))
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("j"))
        {
            pos.x -= speed * Time.deltaTime;
        }


        transform.position = pos;
    }
}
