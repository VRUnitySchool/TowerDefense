using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bow : MonoBehaviour {
    public KeyCode FireButton;
    public Transform spawn;
    public Rigidbody AmmoPrefab;
    public bool inUse;
    public Slider load;
    [SerializeField]
    private float impulse;
    void Update()
    {

        if (Input.GetAxis("VRTriggerPressed") == 1)
         {
             if (inUse == false)
             {
                Rigidbody arrow = Instantiate(AmmoPrefab, spawn.position, transform.rotation) as Rigidbody;
                arrow.AddForce(spawn.forward * impulse, ForceMode.Impulse);
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
