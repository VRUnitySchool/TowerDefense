using UnityEngine;
using VRTK;

public class Node : MonoBehaviour {

    public Vector3 positionOffset;
    public bool triggerPressed;

    [Header("Optional")]
    public GameObject turret;

    BuildManager buildManager;

    private void Start()
    {
        if (GetComponent<VRTK_ControllerEvents>() == null)
        {
            VRTK_Logger.Error(VRTK_Logger.GetCommonMessage(VRTK_Logger.CommonMessageKeys.REQUIRED_COMPONENT_MISSING_FROM_GAMEOBJECT, "VRTK_ControllerEvents_ListenerExample", "VRTK_ControllerEvents", "the same"));
            return;
        }

        GetComponent<VRTK_ControllerEvents>().TriggerPressed += new ControllerInteractionEventHandler(DoTriggerPressed);
        buildManager = BuildManager.instance;
    }

    public Vector3 GetBuildPosition ()
    {
        return transform.position + positionOffset;
    }

    private void DoTriggerPressed(object sender, ControllerInteractionEventArgs e)
    {
        Debug.Log("Worked");
    }

    void OnMouseDown()
    {
        //This is what i had to do to make the shop work
        if (!buildManager.CanBuild)
            return;

        if (turret != null)
        {
            Debug.Log("Can't Build There");
            return;
        }

        buildManager.BuildTurretOn(this);
    }
}
