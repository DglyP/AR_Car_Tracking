using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookCamera : MonoBehaviour
{
    public GameObject mainCamera;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(mainCamera.transform);
    }
}
