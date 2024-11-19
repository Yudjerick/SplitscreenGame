using Mirror;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerOnline : NetworkBehaviour
{
    [SerializeField] private ShootComponentOnline shootComponent;
    [SerializeField] private GameObject keySelectionBanner;
    [SerializeField] private TMP_Text keyReminder;
    [SerializeField] private GameObject winScreen;
    [SerializeField] private float moveForce;
    [SerializeField] private GameObject playerCamera;
    public uint networkId;
    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = transform.parent.GetComponent<Rigidbody2D>();
        winScreen.SetActive(false);
        playerCamera.SetActive(false);
        if (isLocalPlayer)
        {
            playerCamera.SetActive(true);
        }
        networkId = netId;
        print("AAAA");
    }
    /*public void OnActionKeyPressed(InputAction.CallbackContext context)
    {
        _rb.AddForce(moveForce * -transform.up);
        shootComponent.Shoot();
    }*/

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isLocalPlayer)
        {
            _rb.AddForce(moveForce * -transform.up);
            shootComponent.Shoot();
        }
        
    }

    public void ActivateKeySelectionBanner()
    {
        keySelectionBanner.SetActive(true);
    }

    public void ActivateWinScreen()
    {
        winScreen.SetActive(true);
    }
}
