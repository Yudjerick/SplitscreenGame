using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputSubscribing : MonoBehaviour
{
    private List<InputAction> _playerInputs;
    [SerializeField] private InputActionAsset inputActions;
    [SerializeField] private List<Player> players;
    public void SubcribeToInput()
    {
        inputActions.Enable();
        players = FindObjectsOfType<Player>().ToList();
        _playerInputs = new List<InputAction>
        {
            inputActions.FindAction("Player1"),
            inputActions.FindAction("Player2"),
            inputActions.FindAction("Player3"),
            inputActions.FindAction("Player4")
        };

        for (int i = 0; i < players.Count; i++)
        {
            _playerInputs[i].performed += players[i].OnActionKeyPressed;
            var hpComponent = players[i].gameObject.GetComponent<HealthComponent>();
            hpComponent.OnDie += Unsubscribe;
        }
    }

    private void Unsubscribe(HealthComponent healthComponent)
    {
        var player = healthComponent.GetComponent<Player>();
        _playerInputs[players.IndexOf(player)].performed -= player.OnActionKeyPressed;
        healthComponent.OnDie -= Unsubscribe;
    }
}
