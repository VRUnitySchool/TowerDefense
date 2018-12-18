using UnityEngine;
using UnityEngine.UI;

public class UpgradeAgain : MonoBehaviour {

    public GameObject UI;

    public Text upgradeCost2;
    public Button upgradeButton2;

    public TurretBlueprint turretBlueprint;
    private GameObject turret;

    public GameObject node;

    public bool isUpgraded2 = false;

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
