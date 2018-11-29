using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthRotation : MonoBehaviour {

    public Camera myCamera;

    private void Update()
    {
        transform.LookAt(transform.position);
    }
}
