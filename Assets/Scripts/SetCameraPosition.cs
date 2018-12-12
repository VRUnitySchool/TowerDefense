using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCameraPosition : MonoBehaviour {
    [SerializeField]
    private Transform cube;
    [SerializeField]
    private Camera headsetCamera;

	void Update ()
    {
        headsetCamera.transform.LookAt(cube);
        Debug.Log("Set");
	}
	
}
