using UnityEngine;
using VRTK;

public class Node : MonoBehaviour {

    public Vector3 positionOffset;
    private GameObject turret;
    public bool triggerPressed;
    public VRTK_ControllerEvents VRTK_Controllerevents;

    BuildManager buildManager;

    private void Start()
    {
       VRTK_Controllerevents = GetComponent<VRTK_ControllerEvents>();
    }

    private void Update()
    {
        if(VRTK_Controllerevents.triggerClicked == true)
        {
            Debug.Log("Trigger");
        }
    }


    void OnMouseDown()
   {
        //This is what i had to do to make the shop work
        if (buildManager.GetTurretToBuild() == null)
            return;

        if (turret != null)
        {
           Debug.Log("Can't Build There");
           return;
        }

        GameObject turretToBuild = buildManager.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
    }
}
