﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPlacementController : MonoBehaviour {

    [SerializeField]
    private GameObject placeableObjectPrefab;

    [SerializeField]
    private KeyCode newObjectHotKey = KeyCode.A;

    private GameObject currentPlaceableObject;

    private void Update()
    {
        if (currentPlaceableObject != null)
        {
            MoveCurrentPlaceableObjectToMouse();
            ReleaseIfClicked();
        }
    }

    private void ReleaseIfClicked()
    {
        if (Input.GetMouseButtonDown(0))
        {
            currentPlaceableObject = null;
        }
    }

    private void MoveCurrentPlaceableObjectToMouse()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hitinfo;
        if (Physics.Raycast(ray, out hitinfo))
        {
            currentPlaceableObject.transform.position = hitinfo.point;
            currentPlaceableObject.transform.rotation = Quaternion.FromToRotation(Vector3.up, hitinfo.normal);
        }
    }

    private void HandleNewObjectHotKey()

    {
        if  (Input.GetKeyDown(newObjectHotKey))
            if (currentPlaceableObject == null)
            {
                currentPlaceableObject = Instantiate(placeableObjectPrefab);
            }
            else
            {
                Destroy(currentPlaceableObject);
            }
        }
}
