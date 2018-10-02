using UnityEngine;

public class Node : MonoBehaviour {

    private GameObject turret;


    void OnMouseDown()
    {
        if (turret != null)
        {
            Debug.Log("Can't Build There");
            return;
        }

        GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position, transform.rotation);
    }
}
