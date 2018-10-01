using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPlacementController : MonoBehaviour {

    [SerializeField]
    private GameObject placeableObjectPrefab();

    [SerializeField]
    private KeyCode placeableObjectHotKey = KeyCode.A;

    private GameObject currentPlaceableObject();

    private void Update()
    {
        if (currentPlaceableObject != null)
        {
            MoveCurrentPlaceableObjectToMouse
        }
    }

    private void MoveCurrentPlaceableObjectToMouse()
    {
        throw new NotImplementedException();
    }

    private void HandleNewObjectHotKey()

    {
       if {Input.GetKeyDown(HandleNewObjectHotKey)}
        {
            if (currentPlaceableObject == null)
            {
                currentPlaceableObject = Instatiate(placeableObjectPrefab);
            }
            else
            {
                Destroy(currentPlaceableObject);
            }
        }
	}
}
