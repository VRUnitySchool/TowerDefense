using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ow : MonoBehaviour {

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Cube")
        {
            Debug.Log("Ow");
        }
    }
}
