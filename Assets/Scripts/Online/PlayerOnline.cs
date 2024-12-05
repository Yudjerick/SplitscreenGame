using Mirror;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
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
    [SerializeField] private float playerOffset = 2f;
    public uint networkId;
    private Rigidbody2D _rb;

    private void Start()
    {
        int playerCount = FindObjectsOfType<PlayerOnline>().Length;
        //transform.parent.position = Quaternion.Euler(0,0,playerCount*90) * Vector3.up * playerOffset;
        FindAnyObjectByType<GameManagerOnline>().RegisterPlayersHp();
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
