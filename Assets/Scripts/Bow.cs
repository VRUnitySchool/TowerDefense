using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour {
    float _charge;
    public float chargeMax;
    public float chargeRate;
    public KeyCode FireButton;
    public Transform spawn;
    public Rigidbody rigbArrow;

    void Update()
    {
        if (Input.GetKey(FireButton) && _charge < chargeMax)
        {
            _charge += Time.deltaTime * chargeRate;
            Debug.Log(_charge.ToString());
        }

        if (Input.GetKeyUp(FireButton))
            {
                Rigidbody arrow = Instantiate(rigbArrow, spawn.position, Quaternion.identity) as Rigidbody;
                arrow.AddForce(spawn.forward * _charge, ForceMode.Impulse);
            _charge = 0;
            }
    }
}
