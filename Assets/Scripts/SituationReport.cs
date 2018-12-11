using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SituationReport : MonoBehaviour {
    [SerializeField]
   private Renderer cubeRenderer;
    [SerializeField]
   private TextMeshProUGUI Welcome;
    [SerializeField]
   private TextMeshProUGUI tryThrowing;

    private void Update()
    {
        if (!cubeRenderer.isVisible)
        {
            Debug.Log("NotVisible");
        }
    }

}
