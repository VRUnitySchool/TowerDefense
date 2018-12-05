using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopRotation : MonoBehaviour
{
    float lockPos = 0;

    private void Update()
    {
        Camera MyCamera = Camera.main;
        transform.LookAt(transform.position + MyCamera.transform.rotation * Vector3.back, MyCamera.transform.rotation * Vector3.up);
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, lockPos, lockPos);
    }
}
