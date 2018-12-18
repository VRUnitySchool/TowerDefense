using UnityEngine;
using UnityEngine.UI;

public class SellTurret : MonoBehaviour {

    public GameObject turret;
    public int value = 75;

    public GameObject UI;

    public Text sellText;

    public void Sell()
    {
        Destroy(turret);
        PlayerStats.Money += value;
    }
}
