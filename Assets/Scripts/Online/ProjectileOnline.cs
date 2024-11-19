using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class ProjectileOnline : NetworkBehaviour
{

    [SyncVar] public uint ownerNetId;
    private Rigidbody2D _rb;
    [SerializeField] private float speed;
    [SerializeField] private float lifeTime;
    [field: SerializeField] public float Damage { get; set; }
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, lifeTime);
    }

    void Update()
    {
        _rb.velocity = transform.up * speed;
    }
}