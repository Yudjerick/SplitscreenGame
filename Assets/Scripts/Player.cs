using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private ShootComponent shootComponent;
    [SerializeField] private GameObject keySelectionBanner;
    [SerializeField] private TMP_Text keyReminder;
    [SerializeField] private GameObject winScreen;
    [SerializeField] private float moveForce;
    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = transform.parent.GetComponent<Rigidbody2D>();
        winScreen.SetActive(false);
    }
    public void OnActionKeyPressed(InputAction.CallbackContext context)
    {
        _rb.AddForce(moveForce * -transform.up);
        shootComponent.Shoot();
    }

    public void ActivateKeySelectionBanner()
    {
        keySelectionBanner.SetActive(true);
    }

    public void ActivateWinScreen()
    {
        winScreen.SetActive(true);
    }

    public void ActivateKeyReminder(string key)
    {
        keySelectionBanner.SetActive(false);
        keyReminder.text = "Клавиша: " + key;
    }
}
