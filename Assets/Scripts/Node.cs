using UnityEngine;
using VRTK;

public class Node : MonoBehaviour {

    public Vector3 positionOffset;
    private GameObject turret;
    private float trigger;
    private bool check;


    void Update()
    {

        trigger = Input.GetAxis("VRTriggerPressed");

        if (trigger <= .1)
        {
            check = false;
        }




        if (trigger >= .99)
        {
            check = false;
            if (turret != null)
            {
                Debug.Log("Can't Build There");
                return;
            }
            if (check == false)
            {
             GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
             turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
             check = true;
            }
           
        }
    }
}
