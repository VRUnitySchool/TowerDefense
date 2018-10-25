using UnityEngine;
using VRTK;

public class Node : MonoBehaviour {

    public Vector3 positionOffset;
    public VRTK_ControllerEvents VRTK_Controllerevents;

    [Header("Optional")]
    public GameObject turret;

    BuildManager buildManager;
    
    public Vector3 GetBuildPosition ()
    {
        return transform.position + positionOffset;
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
