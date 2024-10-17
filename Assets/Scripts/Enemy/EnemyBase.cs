using UnityEngine;

public class EnemyBase : MonoBehaviour
{

    [SerializeField] protected int baseHealth;
    [SerializeField] protected GameObject explosionPrefab;
    
    private int _currentHealth;

    private void Start()
    {
        _currentHealth = baseHealth;
    }

    public virtual void TakeDamage(int damage)
    {
        _currentHealth -= damage;
        if (_currentHealth <= 0)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        GameObject explosion = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        Destroy(explosion, 0.5f);
        Destroy(gameObject);
    }
}
