using UnityEngine;

public class Shop : MonoBehaviour {

    public Vector3 positionOffset;
    public TurretBlueprint standardTurret;
    public GameObject node;
    public GameObject turret;
    public GameObject image;

    BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void PurchaseStandardTurret ()
    {
        
        Debug.Log("Select Turret Selected");
        buildManager.SelectTurretToBuild(standardTurret);
        Instantiate(turret, node.transform.position + positionOffset, Quaternion.identity);

        image.SetActive(false);
        
    }

    public void Close()
    {
        image.SetActive(false);
        Debug.Log("FunTimes");
    }

}
