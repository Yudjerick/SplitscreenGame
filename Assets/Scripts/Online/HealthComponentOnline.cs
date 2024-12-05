using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using Mirror;

public class HealthComponentOnline : NetworkBehaviour
{
    [SerializeField] private Image greenLine;
    [SerializeField] private float maxHealth = 100f;
    [SyncVar(hook = nameof(SyncHealthHook))]
    [SerializeField] private float health = 100f;
    [SerializeField] private float lineLength;
    [SerializeField] private GameObject deathScreen;
    [SerializeField] private GameObject healthBar;
    public bool Alive = true;

    public UnityAction<HealthComponentOnline> OnDie;
    void Start()
    {
        UpdateHpVisuals();
        deathScreen.SetActive(false);
        Alive = true;
        print("BBBBB");
    }

    private void UpdateHpVisuals()
    {

        greenLine.fillAmount = health / maxHealth;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        ProjectileOnline projectile = collision.GetComponent<ProjectileOnline>();
        print("Hit");
        
        if (projectile.ownerNetId != netId)
        {
            CmdOnProjectileHit(projectile.Damage);
        }
        
    }

    [Command]
    void CmdOnProjectileHit(float damage)
    {
        health -= damage;
        //RpcSyncHealth(damage);
    }

    //[ClientRpc]
    void SyncHealthHook(float oldHealth, float newHealth)
    {
        health = newHealth;

        if (health <= 0)
        {
            health = 0;
            Die();
        }
        UpdateHpVisuals();
    }

    private void Die()
    {
        FindAnyObjectByType<GameManagerOnline>().CmdCheckVictory();
        Alive = false;
        deathScreen?.SetActive(true);
        OnDie?.Invoke(this);
        gameObject.SetActive(false);
        healthBar?.SetActive(false);

    }
}
