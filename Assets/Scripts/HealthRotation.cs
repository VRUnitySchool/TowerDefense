using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthRotation : MonoBehaviour {

    public Camera myCamera;

    private void Update()
    {
        transform.LookAt(transform.position + myCamera.transform.rotation * Vector3.back, myCamera.transform.rotation * Vector3.up);
    }
}
