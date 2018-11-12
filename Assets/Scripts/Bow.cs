using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour {
    float _charge;
    public float chargeMax;
    public KeyCode FireButton;
    public Transform spawn;
    public GameObject AmmoPrefab;
    public bool inUse;

    void Update()
    {

        if (Input.GetAxis("VRTriggerPressed") != 0)
        {
            Debug.Log(Input.GetAxis("VRTriggerPressed"));
            _charge += Input.GetAxis("VRTriggerPressed") / 5;
        }

        if (Input.GetAxis("VRTriggerPressed") != 0)
        {
            GameObject arrow = Instantiate(AmmoPrefab, spawn.position, transform.rotation) as GameObject;
            if (arrow.transform.localScale <= )
            arrow.transform.localScale += new Vector3(Input.GetAxis("VrTriggerPressed"), Input.GetAxis("VrTriggerPressed"), Input.GetAxis("VrTriggerPressed"));
        }

        /* if (Input.GetAxis("VRTriggerPressed") == 1)
         {
             if (inUse == false)
             {
                 GameObject arrow = Instantiate(AmmoPrefab, spawn.position, transform.rotation) as GameObject;
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
         */
    }
}
