using UnityEngine;

public class Shop : MonoBehaviour {

    public TurretBlueprint standardTurret;

    BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void PurchaseStandardTurret ()
    {
        Debug.Log("Select Turret Selected");
        buildManager.SelectTurretToBuild(standardTurret);
    }

    public void Close()
    {
        Destroy(gameObject);
    }

}
