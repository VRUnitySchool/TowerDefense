using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour {
    float _charge;
    public float chargeMax;
    public KeyCode FireButton;
    public Transform spawn;
    public Rigidbody rigbArrow;

    void Update()
    {

        if (Input.GetAxis("VRTriggerPressed1") == 1)
        {
            _charge += 1;
        }

        if (Input.GetKeyDown("VRTriggerPressed")){
            Rigidbody arrow = Instantiate(rigbArrow, spawn.position, Quaternion.identity);
            arrow.AddForce(spawn.forward * _charge, ForceMode.Impulse);
            _charge = 0;
        }
    }
}
