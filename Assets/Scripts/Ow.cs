using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ow : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI hit;
    [SerializeField]
    private TextMeshProUGUI bulletText;
    [SerializeField]
    private Bow bow;

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Cube")
        {
            hit.enabled = false;
        }
        if (col.gameObject.name == "Cube" && hit.enabled == false)
        {
            bulletText.enabled = true;
            bow.enabled = true;
        }


    }
}