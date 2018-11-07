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
        _charge = Input.GetAxis("VRTriggerPressed1");

        if (Input.GetAxis("VRTriggerPressed") == 1){
            Rigidbody arrow = Instantiate(rigbArrow, spawn.position, Quaternion.identity) as Rigidbody;
            arrow.AddForce(spawn.forward * _charge * 6, ForceMode.Impulse);
            _charge = 0;
        }
    }
   /* private void OnCollisionEnter(Collision collision)
    {
        Destroy(rigbArrow);
    } */
}
