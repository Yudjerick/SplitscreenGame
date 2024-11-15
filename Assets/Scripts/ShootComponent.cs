using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootComponent : MonoBehaviour
{
    [SerializeField] private Projectile projectile;
    [SerializeField] private float reloadTime;
    private float _ammo = 1;
    private float _maxAmmo = 1;
    
    public void Shoot()
    {
        if(_ammo >= 1)
        {
            var instance = Instantiate(projectile, transform.position, transform.rotation);
            instance.owner = gameObject.GetComponent<Player>();
            _ammo -= 1;
        }
        
    }

    private void Update()
    {
        if (_ammo <= _maxAmmo)
        {
            _ammo += Time.deltaTime * (1 / reloadTime);
        }
    }
}
