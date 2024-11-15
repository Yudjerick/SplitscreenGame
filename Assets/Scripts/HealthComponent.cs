using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class HealthComponent : MonoBehaviour
{
    [SerializeField] private Image greenLine;
    [SerializeField] private float maxHealth = 100f;
    [SerializeField] private float health = 100f;
    [SerializeField] private float lineLength;
    [SerializeField] private GameObject deathScreen;
    [SerializeField] private GameObject healthBar;
    public bool Alive = true;

    public UnityAction<HealthComponent> OnDie;
    void Start()
    {
        UpdateHpVisuals();
        deathScreen.SetActive(false);
        Alive = true;
    }

    private void UpdateHpVisuals()
    {

        greenLine.fillAmount = health / maxHealth;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Projectile projectile = collision.GetComponent<Projectile>();
        if(projectile.owner == GetComponent<Player>())
        {
            return;
        }
        if(projectile != null)
        {
            health -= projectile.Damage;
            
            if(health <= 0)
            {
                health = 0;
                Die();
            }
            UpdateHpVisuals();
        }
    }

    private void Die()
    {
        Alive = false;
        deathScreen?.SetActive(true);
        OnDie?.Invoke(this);
        gameObject.SetActive(false);
        healthBar?.SetActive(false);
        
    }
}
