using UnityEngine;

public class Shop : MonoBehaviour {

	public void PurchaseStandardTurret ()
    {
        Debug.Log("Standard Turret Purchased");
    }

    public void Close()
    {
        Destroy(gameObject);
    }

}
