using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BootstrapOnline : NetworkBehaviour
{
    private void Start()
    {
        print("Bootstrap");
        //FindAnyObjectByType<InputSubscribing>().SubcribeToInput();
        //FindAnyObjectByType<ActionRebinder>().RebindPlayerInputKeys();
        
    }
}
