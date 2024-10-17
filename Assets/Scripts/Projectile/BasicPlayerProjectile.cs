using UnityEngine;

public class BasicPlayerProjectile : ProjectileBase
{

    private void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    void Update()
    {
        Move();
    }

    protected override void Move()
    {
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
    }
}
