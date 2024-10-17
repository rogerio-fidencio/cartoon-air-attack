using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBase : MonoBehaviour
{

    [SerializeField] protected float moveSpeed;
    [SerializeField] protected float lifeTime;

    protected virtual void Move(){}
}
