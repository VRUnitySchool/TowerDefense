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
    public Image load;

    void Update()
    {
    
       if (Input.GetAxis("VRTriggerPressed") != 1)
        {
            _charge += Input.GetAxis("VRTriggerPressed");
            load.fillAmount = _charge;
        }

        if (Input.GetAxis("VRTriggerPressed") == 1)
         {
             if (inUse == false)
             {
                 Rigidbody arrow = Instantiate(AmmoPrefab, spawn.position, transform.rotation) as Rigidbody;
                arrow.AddForce(spawn.forward * _charge, ForceMode.Impulse);
                 _charge = 0;
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
