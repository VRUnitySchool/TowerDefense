using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bow : MonoBehaviour {
    float _charge;
    public float chargeMax;
    public KeyCode FireButton;
    public Transform spawn;
    public Rigidbody AmmoPrefab;
    public bool inUse;
    public Slider load;

    void Update()
    {

        if (Input.GetAxis("VRTriggerPressed") != 1 && _charge <= chargeMax)
        {
            _charge += Input.GetAxis("VRTriggerPressed")/7;
            load.value += _charge;
            if (Input.GetAxis("VRTriggerPressed") == 0)
            {
                _charge = 0;
                load.value = 0;
            }
        }

        if (Input.GetAxis("VRTriggerPressed") == 1)
         {
             if (inUse == false)
             {
                 Rigidbody arrow = Instantiate(AmmoPrefab, spawn.position, transform.rotation) as Rigidbody;
                arrow.AddForce(spawn.forward * _charge, ForceMode.Impulse);
                _charge = 0;
                load.value = 0;
                inUse = true;
             }
         }
         else
         {
             if (inUse == true)
             {
                 inUse = false;
             }
         }
    }
}
