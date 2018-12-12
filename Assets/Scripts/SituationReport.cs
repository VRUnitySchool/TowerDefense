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
        StartCoroutine(checkVisible());


    }

    IEnumerator checkVisible()
    {
        yield return new WaitForSeconds(1);
    if (!cubeRenderer.isVisible)
        {
            Welcome.enabled = false;
            tryThrowing.enabled = true;
        }
    }

}
