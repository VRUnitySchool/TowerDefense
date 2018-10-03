using UnityEngine;

public class BuildManager : MonoBehaviour {

    public static BuildManager instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one BuildManager in scene");
            return;
        }
        instance = this;
    }

    public GameObject standardTurretPrefab;

    private void Update()
    {

        if (turretToBuild != null)
        {
            MoveTurretToCamera();
        }

      
    }

 private void MoveTurretToCamera()
        {
            standardTurretPrefab.transform.position = Camera.main.transform.position + Camera.main.transform.forward * 5;
        }


    void Start()
    {
       
            turretToBuild = standardTurretPrefab;
    }

    private GameObject turretToBuild;

    public GameObject GetTurretToBuild ()
    {
        return turretToBuild;
    }

}
