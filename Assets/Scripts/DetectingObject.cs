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
        if (col.gameObject.tag == "Enemy")
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


    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == ("Floor"))
        {
            Destroy(this.gameObject, 3);
        }

    }

}
