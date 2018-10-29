using UnityEngine;

public class Shop : MonoBehaviour {

    public Vector3 positionOffset;
    public TurretBlueprint standardTurret;
<<<<<<< HEAD
    public GameObject node;
    public GameObject turret;
=======
    public GameObject image;
>>>>>>> eae2c53710aba030cf847b356f78adae6b65e3a5

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
        
    }

    public void Close()
    {
        image.SetActive(false);
    }

}
