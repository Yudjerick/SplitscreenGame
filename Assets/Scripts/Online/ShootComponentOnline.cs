using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootComponentOnline : NetworkBehaviour
{
    [SerializeField] private GameObject projectile;
    [SerializeField] private float reloadTime;
    private float _ammo = 1;
    private float _maxAmmo = 1;

    [Command(requiresAuthority = false)]
    public void Shoot()
    {
        if (_ammo >= 1)
        {
            GameObject instance = Instantiate(projectile, transform.position, transform.rotation);
            instance.GetComponent<ProjectileOnline>().ownerNetId = netId;
            print(netId);
            _ammo -= 1;
            NetworkServer.Spawn(instance);
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
