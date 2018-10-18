using UnityEngine;

public class DetectingObject : MonoBehaviour {

    private Transform target;
    public int damage = 50;

    public void Seek (Transform _target)
    {
        target = _target;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "EnemyFast(Clone)")
        {
            Debug.Log("Hit");
            Destroy(col.gameObject);
        }

    }

    void HitTarget()
    {
        Damage(target);

        Destroy(gameObject);
    }

    void Damage(Transform enemy)
    {
        Enemy e = enemy.GetComponent<Enemy>();
        if (e != null)
        {
            e.TakeDamage(damage);
        }

    }

}
