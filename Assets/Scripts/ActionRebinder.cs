using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActionRebinder : MonoBehaviour
{
    [SerializeField] private InputActionAsset inputActions;
    private List<InputAction> _playerInputs;
    [SerializeField] private List<string> _exludedPathes;
    private int _currentRebindingIndex = 0;
    private List<Player> players;
    public void RebindPlayerInputKeys()
    {
        players = FindObjectsOfType<Player>().ToList();
        _playerInputs = new List<InputAction>();
        _playerInputs.Add(inputActions.FindAction("Player1"));
        _playerInputs.Add(inputActions.FindAction("Player2"));
        _playerInputs.Add(inputActions.FindAction("Player3"));
        _playerInputs.Add(inputActions.FindAction("Player4"));

        _exludedPathes = new List<string>();
        
        RemapButtonClicked(_playerInputs[_currentRebindingIndex], players[_currentRebindingIndex]);
    }
    void RemapButtonClicked(InputAction actionToRebind, Player player)
    {
        player.ActivateKeySelectionBanner();
        actionToRebind.Disable();
        var rebindOperation = actionToRebind.PerformInteractiveRebinding()
                    // To avoid accidental input from mouse motion
                    .WithControlsExcluding("Mouse")
                    .WithControlsExcluding("/Keyboard/anyKey")
                    .OnMatchWaitForAnother(0.1f);
        foreach (var path in _exludedPathes)
        {
            rebindOperation = rebindOperation.WithControlsExcluding(path);
        }
        rebindOperation.Start();

        rebindOperation.OnComplete(op => {
            player.ActivateKeyReminder(op.selectedControl.name);
            actionToRebind.Enable();
            _exludedPathes.Add(op.selectedControl.path);
            
            _currentRebindingIndex++;
            if(_currentRebindingIndex < players.Count)
            {
                RemapButtonClicked(_playerInputs[_currentRebindingIndex], players[_currentRebindingIndex]);
            }
            op.Dispose();
        });
    }
}
