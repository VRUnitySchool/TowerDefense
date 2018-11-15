using UnityEngine;

public class DetectingObject : MonoBehaviour {

    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.name == "EnemyFast(Clone)")
        {
            Debug.Log("Hit");
            Damage(col.transform);
        }

        if (col.gameObject.name == "EnemyNormal(Clone)")
        {
            Debug.Log("Hit");
            Damage(col.transform);
        }

        if (col.gameObject.name == "EnemyStrong(Clone)")
        {
            Debug.Log("Hit");
            Damage(col.transform);
        }

    }

    void Damage(Transform enemy)
    {
        Enemy e = enemy.GetComponent<Enemy>();
        if (e != null)
        {
            e.TakeDamage(20);
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
