using UnityEngine;

public class DetectingObject : MonoBehaviour {

    private Enemy enemy;

    private void Start()
    {
        enemy = GetComponent<Enemy>();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "EnemyFast(Clone)")
        {
            Debug.Log("Hit");
            enemy.health -= 90;
        }
        else if (col.gameObject.name == "EnemyNormal(Clone)")
        {
            Debug.Log("Hit");
            enemy.health -= 90;
        }
        else if (col.gameObject.name == "EnemyStrong(Clone)")
        {
            Debug.Log("Hit");
            enemy.health -= 90;
        }

    }

 
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == ("Floor"))
        {
            Destroy(this.gameObject, 3);
        }

    }

}
