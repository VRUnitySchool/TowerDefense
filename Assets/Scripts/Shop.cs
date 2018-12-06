using UnityEngine;

public class Shop : MonoBehaviour {

    public Vector3 positionOffset;
    public TurretBlueprint standardTurret;
    public GameObject node;
    public GameObject turret;
    public GameObject image;
    public GameObject buildEffect;

    BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void PurchaseStandardTurret ()
    {
        //Build Turret
        Debug.Log("Turret Selected");
        buildManager.SelectTurretToBuild(standardTurret);
        Instantiate(turret, node.transform.position + positionOffset, Quaternion.identity);

        //Play Build effect
        GameObject effect = Instantiate(buildEffect, node.transform.position, Quaternion.identity);
        Destroy(effect, 3f);

        image.SetActive(false);
        
    }

    public void Close()
    {
        image.SetActive(false);
        Debug.Log("FunTimes");
    }

}
