using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthRotation : MonoBehaviour
{

    private void Update()
    {
        Camera MyCamera = Camera.main;
        transform.LookAt(transform.position + MyCamera.transform.rotation * Vector3.back, MyCamera.transform.rotation * Vector3.up);
    }
}

