using UnityEngine;
using VRTK;

public class Node : MonoBehaviour {

    public Vector3 positionOffset;
    private GameObject turret;
    public bool triggerPressed;

    private void Start()
    {
        if (GetComponent<VRTK_ControllerEvents>() == null)
        {
            VRTK_Logger.Error(VRTK_Logger.GetCommonMessage(VRTK_Logger.CommonMessageKeys.REQUIRED_COMPONENT_MISSING_FROM_GAMEOBJECT, "VRTK_ControllerEvents_ListenerExample", "VRTK_ControllerEvents", "the same"));
            return;
        }

        GetComponent<VRTK_ControllerEvents>().TriggerPressed += new ControllerInteractionEventHandler(DoTriggerPressed);
    }

    private void DoTriggerPressed(object sender, ControllerInteractionEventArgs e)
    {
        Debug.Log("Worked");
    }

    void OnMouseDown()
    {
        if (turret != null)
        {
            Debug.Log("Can't Build There");
            return;
        }

        GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
    }
}
