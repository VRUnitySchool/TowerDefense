using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour {

    [HideInInspector]
    public Vector3 positionOffset;
    public GameObject node;
    public GameObject image;
    public GameObject buildEffect;

    [HideInInspector]
    public bool isUpgraded = false;
    public bool isUpgraded2 = false;

    public TurretBlueprint standardTurret;
    public TurretBlueprint turretBlueprint;
    public GameObject turret;

    private Node target;
    private TurretBlueprint turretToBuild;


    BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectTurretToBuild(TurretBlueprint turret)
    {
        turretToBuild = turret;
    }

    public void PurchaseStandardTurret ()
    {
        //Build Turret
        Debug.Log("Turret Selected");
        buildManager.SelectTurretToBuild(standardTurret);
        Instantiate(turretBlueprint.prefab, node.transform.position + positionOffset, Quaternion.identity);

        //Build Upgraded Turret
        GameObject _turret = (GameObject)Instantiate(standardTurret.upgradedPrefab, node.transform.position, Quaternion.identity);
        turret = _turret;

        //Build Upgraded Turret2
        GameObject _Turret = (GameObject)Instantiate(standardTurret.upgradedPrefab2, node.transform.position, Quaternion.identity);
        turret = _Turret;

        //Play Build effect
        GameObject effect = Instantiate(buildEffect, node.transform.position, Quaternion.identity);
        Destroy(effect, 3f);

        image.SetActive(false);
        
    }

    public void Close()
    {
        image.SetActive(false);
    }

    

    public void UpgradeTurretAgain()
    {
        if (PlayerStats.Money < turretBlueprint.upgradeCost2)
        {
            Debug.Log("Not enough money to upgrade that!");
            return;
        }
        PlayerStats.Money -= turretBlueprint.upgradeCost2;

        //Get rid of the old turret
        Destroy(turret);


        isUpgraded2 = true;

        Debug.Log("Turret upgraded!");
    }

}
