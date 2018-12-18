using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellTurret : MonoBehaviour {

    public GameObject turret;
    public int value = 75;

	public void Sell()
    {
        Destroy(turret);
        PlayerStats.Money += value;
    }
}
