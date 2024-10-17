using UnityEngine;

public class ProjectileBase : MonoBehaviour
{

    [SerializeField] protected float moveSpeed;
    [SerializeField] protected float lifeTime;
    [SerializeField] public int damage;

    protected virtual void Move(){}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<EnemyBase>().TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
