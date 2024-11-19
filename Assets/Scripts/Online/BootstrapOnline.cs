using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BootstrapOnline : NetworkBehaviour
{
    private void OnConnectedToServer()
    {
        FindAnyObjectByType<InputSubscribing>().SubcribeToInput();
        FindAnyObjectByType<ActionRebinder>().RebindPlayerInputKeys();
        FindAnyObjectByType<VictoryManager>().RegisterPlayersHp();
    }
}
