using UnityEngine;
using UnityEngine.UI;

public class Upgrade : MonoBehaviour {

    public GameObject UI;

    public Text upgradeCost;
    public Button upgradeButton;

    public TurretBlueprint turretBlueprint;
    private GameObject turret;

    public GameObject node;

    public bool isUpgraded = false;

    public void UpgradeTurret()
    {
        if (PlayerStats.Money < turretBlueprint.upgradeCost)
        {
            Debug.Log("Not enough money to upgrade that!");
            return;
        }

        if (!isUpgraded && PlayerStats.Money > turretBlueprint.upgradeCost)
        {
            PlayerStats.Money -= turretBlueprint.upgradeCost;

            //Get rid of the old turret
            Destroy(turret);

            isUpgraded = true;

            //Build better turret
            GameObject _turret = (GameObject)Instantiate(turretBlueprint.upgradedPrefab, node.transform.position, Quaternion.identity);
            turret = _turret;

            Debug.Log("Turret upgraded!");
            return;
        }
        
    }

}
