using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour {

    [HideInInspector]
    public Vector3 positionOffset;
    public GameObject node;
    public GameObject image;
    public GameObject buildEffect;
    public bool isUpgraded = false;

    public TurretBlueprint standardTurret;
    public Text upgradeCost;
    public Button upgradeButton;
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

        //Build a new one
        GameObject _turret = (GameObject)Instantiate(standardTurret.upgradedPrefab, node.transform.position, Quaternion.identity);
        turret = _turret;
        

        //Play Build effect
        GameObject effect = Instantiate(buildEffect, node.transform.position, Quaternion.identity);
        Destroy(effect, 3f);

        image.SetActive(false);
        
    }

    public void Close()
    {
        image.SetActive(false);
    }

    public void UpgradeTurret()
    {
        if (PlayerStats.Money < turretBlueprint.upgradeCost)
        {
            Debug.Log("Not enough money to upgrade that!");
            return;
        }
        PlayerStats.Money -= turretBlueprint.upgradeCost;

        //Get rid of the old turret
        Destroy(turret);
        

        isUpgraded = true;

        Debug.Log("Turret upgraded!");
    }

}
